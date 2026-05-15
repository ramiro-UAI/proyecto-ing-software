using SRV5283_MB;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV_5283_MB
{
    public class Usuario5283_MB: Entity5283_MB
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Perfil { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Bloqueo { get; set; }

        public int ContBloqueo { get; set; }
    }
}
