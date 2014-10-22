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
    public class mPersonas
    {
        bd_esEntities ctx;
        public mPersonas()
        {
            Mapper.CreateMap<es_terceros, es_tercerosDto>();
            Mapper.CreateMap<es_terceros, es_tercerosFotoDto>();
            Mapper.CreateMap<es_tercerosDto, es_terceros>();
        }
        public List<es_tercerosDto> Gets()
        {
            List<es_tercerosDto> lrPersonas = new List<es_tercerosDto>();
            using(ctx = new bd_esEntities())
            {
                List<es_terceros> lPersonas = ctx.es_terceros.ToList();
                Mapper.Map(lPersonas, lrPersonas);
            }
            return lrPersonas;
        }
        public es_tercerosFotoDto GetPorIdHuella(int IdHuella)
        {
            es_tercerosFotoDto rPersonas = new es_tercerosFotoDto();
            using (ctx = new bd_esEntities())
            {
                es_terceros lPersonas = ctx.es_terceros.Where(t => t.indice_id == IdHuella).FirstOrDefault();
                Mapper.Map(lPersonas, rPersonas);
            }
            return rPersonas;
        }
        public ByARpt Insert(es_tercerosDto Reg)
        {
            cmdInsert o = new cmdInsert();
            o.oDto = Reg;
            return o.Enviar();
        }
        public ByARpt AsignarCodigoHuellaPersona(string idPersona, int idHuella)
        {
            ByARpt res = new ByARpt();
            using (ctx = new bd_esEntities())
            {
                
                es_terceros persona = ctx.es_terceros.Where(t => t.terceroid == idPersona).FirstOrDefault();
                persona.indice_id = idHuella;
                if (persona != null)
                {
                    try
                    {
                        ctx.SaveChanges();
                        res.Error = false;
                        res.Mensaje = "Operacion realizada correctamente...";
                    }
                    catch
                    {
                        res.Error = true;
                        res.Mensaje = "Ha ocurrido un error al intentar guardar...";
                    }
                }
                else
                {
                    res.Error = true;
                    res.Mensaje = "Error: el documento no se encuentra...";
                }
            }
            return res;
        }
        public ByARpt Update(es_tercerosDto Reg)
        {
            cmdUpdate o = new cmdUpdate();
            o.oDto = Reg;
            return o.Enviar();
        }
        class cmdInsert : absTemplate
        {
            public es_tercerosDto oDto { get; set; }
            es_terceros Dto { get; set; }

            #region ImplementaciónMetodosAbstractos
            protected internal override bool esValido()
            {
                es_terceros objO = ctx.es_terceros.Where(t => t.terceroid == oDto.terceroid).FirstOrDefault();
                if (objO == null) return true;
                else
                {
                    byaRpt.Mensaje = "Ya se encuentra el tercero con ese número de identificación";
                    byaRpt.Error = true;
                    return false;
                }
            }
            protected internal override void Antes()
            {
                Dto = new es_terceros();
                Mapper.Map(oDto, Dto);
                ctx.es_terceros.Add(Dto);
                byaRpt.id = Dto.terceroid.ToString();
            }
            #endregion
        }
        class cmdUpdate : absTemplate
        {
            public es_tercerosDto oDto { get; set; }
            es_terceros Dto { get; set; }
            es_terceros objO { get; set; }
            #region ImplementaciónMetodosAbstractos

            protected internal override bool esValido()
            {
                objO = ctx.es_terceros.Where(t => t.terceroid == oDto.terceroid).FirstOrDefault();
                if (objO != null) return true;
                else
                {
                    byaRpt.Mensaje = "No se encuentra el tercero con ese número de identificación";
                    byaRpt.Error = true;
                    return false;
                }
            }

            protected internal override void Antes()
            {
                objO.correo = oDto.correo;
                objO.direccion = oDto.direccion;
                objO.nombre = oDto.nombre;
                objO.telefono = oDto.telefono;
                objO.tipodoc = oDto.tipodoc;
                objO.tipoper = oDto.tipoper;
                byaRpt.id = objO.terceroid;
            }
            #endregion
        }
    }
}
