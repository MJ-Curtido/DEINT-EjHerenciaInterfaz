using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Operario:Empleado
    {
        public Operario(String Nombre):base(Nombre)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} -> Operario";
        }
    }
}