using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Lavadora:Electrodomestico
    {
        private const Double CARGA = 5;

        public Double Carga { get; set; } = CARGA;

        public Lavadora()
        {

        }

        public Lavadora(Double PrecioBase, Double Peso): base(PrecioBase, Peso)
        {

        }

        public Lavadora(double Carga, Double PrecioBase, Colores Colorado, Char Consumo, Double Peso): base(PrecioBase, Colorado, Consumo, Peso)
        {
            this.Carga = Carga;
        }

        public void precioFinal()
        {
            base.PrecioFinal();
            if (this.Carga > 30)
            {
                base.PrecioBase += 50;
            }
        }
    }
}