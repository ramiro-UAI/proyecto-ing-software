using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public class Evento5283_MB: Entity5283_MB
    {
        public DateTime Date {  get; set; }
        public string NombreUsuario {  get; set; }
        public string Descripcion { get; set; }
        public int Criticidad { get; set; }
    }
}
