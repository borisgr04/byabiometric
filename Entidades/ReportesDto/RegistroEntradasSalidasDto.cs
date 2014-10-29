using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ReportesDto
{
    public class RegistroEntradasSalidasDto
    {
        public string nombre { get; set; }
        public string idTercero { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public TimeSpan TiempoDentro { get; set; }
    }
}
