using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class es_entradassalidasDto
    {
        public int id { get; set; }
        public string idTercero { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public string Estado { get; set; }
    }
}
