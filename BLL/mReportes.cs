using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using ByA;
using AutoMapper;
using Entidades.ReportesDto;

namespace BLL
{
    public class mReportes
    {
        public mReportes()
        {
        }
        bd_esEntities ctx;

        public List<RegistroEntradasSalidasDto> GetEntradasSalidasPersona(DateTime FInicial, DateTime FFinal, string idTercero)
        {
            List<RegistroEntradasSalidasDto> lrRES = new List<RegistroEntradasSalidasDto>();
            using (ctx = new bd_esEntities())
            {
                es_terceros persona = ctx.es_terceros.Where(t => t.terceroid == idTercero).FirstOrDefault();
                if (persona != null)
                {
                    List<es_entradassalidas> lRES = ctx.es_entradassalidas.Where(t => t.idTercero == idTercero && t.FechaEntrada >= FInicial && t.FechaEntrada <= FFinal).OrderBy(t => t.FechaEntrada).ToList();
                    if (lRES != null)
                    {
                        foreach (es_entradassalidas item in lRES)
                        {
                            if (item.FechaSalida != null)
                            {
                                RegistroEntradasSalidasDto registro = new RegistroEntradasSalidasDto();
                                registro.idTercero = idTercero;
                                registro.nombre = persona.nombre;
                                registro.FechaEntrada = item.FechaEntrada.ToString();
                                registro.FechaSalida = item.FechaSalida.ToString();

                                DateTime FE = (DateTime)item.FechaEntrada;
                                DateTime FS = (DateTime)item.FechaSalida;
                                TimeSpan Duracion = FS - FE;
                                registro.TiempoDentro = Duracion.Hours + (Duracion.Minutes / 60) + (Duracion.Seconds / 3600);

                                lrRES.Add(registro);
                            }
                        }
                    }
                }
            }
            return lrRES;
        }

    }
}
