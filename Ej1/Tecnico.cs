using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Tecnico:Operario
    {
        public Tecnico(String Nombre):base(Nombre)
        {

        }
        public override string ToString()
        {
            return $"{base.ToString()} -> Técnico";
        }
    }
}