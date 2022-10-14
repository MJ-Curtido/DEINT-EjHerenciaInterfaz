using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Empleado
    {
        public String Nombre { get; set; }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Empleado {this.Nombre}";
        }
    }
}
