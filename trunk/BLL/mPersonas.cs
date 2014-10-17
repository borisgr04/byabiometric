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

        public ByARpt Insert(es_tercerosDto Reg)
        {
            cmdInsert o = new cmdInsert();
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
    }
}
