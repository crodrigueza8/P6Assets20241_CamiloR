using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Assets20241_CamiloR.Models
{
    public class UserPost
    {

        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        public string Contrasennia { get; set; } = null!;

        public int CodigoDeRol { get; set; }

    }
}
