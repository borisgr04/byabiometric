using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using Entidades;
using ByA;

namespace BLL
{
    public class mEntradasSalidas
    {
        bd_esEntities ctx;
        public mEntradasSalidas()
        {
            Mapper.CreateMap<es_entradassalidas, es_entradassalidasDto>();
            Mapper.CreateMap<es_entradassalidasDto, es_entradassalidas>();
        }

        public ByARpt NuevoRegistro(string idTercero)
        {
            es_entradassalidasDto UltimoRegistro = GetUltimoRegistro(idTercero);
            ByARpt res = new ByARpt();
            if (UltimoRegistro.Estado == "A")
            {
                UltimoRegistro.FechaSalida = DateTime.Now;
                UltimoRegistro.Estado = "C";
                res = Update(UltimoRegistro);
                if (res.Error == false)
                {
                    res.Mensaje = "Salida";
                }
            }
            else
            {
                es_entradassalidasDto NuevoRegistro = new es_entradassalidasDto();
                NuevoRegistro.idTercero = idTercero;
                NuevoRegistro.FechaEntrada = DateTime.Now;
                NuevoRegistro.Estado = "A";
                res = Insert(NuevoRegistro);
                if (res.Error == false)
                {
                    res.Mensaje = "Entrada";
                }
            }
            return res;
        }

        public ByARpt Insert(es_entradassalidasDto Reg)
        {
            cmdInsert o = new cmdInsert();
            o.oDto = Reg;
            return o.Enviar();
        }

        public ByARpt Update(es_entradassalidasDto Reg)
        {
            cmdUpdate o = new cmdUpdate();
            o.oDto = Reg;
            return o.Enviar();
        }

        public es_entradassalidasDto GetUltimoRegistro(string idTercero)
        {
            es_entradassalidasDto rRegistro = new es_entradassalidasDto();
            using (ctx = new bd_esEntities())
            {
                es_entradassalidas Registro = ctx.es_entradassalidas.Where(t => t.idTercero == idTercero).OrderByDescending(t => t.FechaEntrada).FirstOrDefault();
                Mapper.Map(Registro, rRegistro);
            }
            return rRegistro;
        }

        class cmdInsert : absTemplate
        {
            public es_entradassalidasDto oDto { get; set; }
            es_entradassalidas Dto { get; set; }

            #region ImplementaciónMetodosAbstractos
            protected internal override bool esValido()
            {
                es_entradassalidas objO = ctx.es_entradassalidas.Where(t => t.idTercero == oDto.idTercero && t.FechaEntrada == oDto.FechaEntrada).FirstOrDefault();
                if (objO == null) return true;
                else
                {
                    byaRpt.Mensaje = "Ya se encuentra este registro";
                    byaRpt.Error = true;
                    return false;
                }
            }
            protected internal override void Antes()
            {
                Dto = new es_entradassalidas();
                Mapper.Map(oDto, Dto);
                ctx.es_entradassalidas.Add(Dto);
                byaRpt.id = Dto.idTercero.ToString();
            }
            #endregion
        }

        class cmdUpdate : absTemplate
        {
            public es_entradassalidasDto oDto { get; set; }
            es_entradassalidas Dto { get; set; }
            es_entradassalidas objO { get; set; }
            #region ImplementaciónMetodosAbstractos

            protected internal override bool esValido()
            {
                objO = ctx.es_entradassalidas.Where(t => t.id == oDto.id).OrderByDescending(t => t.FechaEntrada).FirstOrDefault();
                if (objO != null) return true;
                else
                {
                    byaRpt.Mensaje = "No se encuentra...";
                    byaRpt.Error = true;
                    return false;
                }
            }

            protected internal override void Antes()
            {
                objO.FechaSalida = DateTime.Now;
                objO.Estado = "C";
                byaRpt.id = objO.idTercero;
            }
            #endregion
        }
    }
}
