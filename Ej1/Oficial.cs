using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Oficial:Operario
    {
        public Oficial(String Nombre):base(Nombre)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} -> Oficial";
        }
    }
}