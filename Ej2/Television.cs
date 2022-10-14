using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Television:Electrodomestico
    {
        private const Double RESOLUCION = 20;
        private const Boolean SINTONIZADORTDT = false;

        public Double Resolucion { get; set; } = RESOLUCION;
        public Boolean SintonizadorTDT { get; set; } = SINTONIZADORTDT;

        public Television()
        {
            
        }

        public Television(Double PrecioBase, Double Peso) : base(PrecioBase, Peso)
        {

        }

        public Television(Double Resolucion, Boolean SintonizadorTDT, Double PrecioBase, Colores Colorado, Char Consumo, Double Peso) : base(PrecioBase, Colorado, Consumo, Peso)
        {
            this.Resolucion = Resolucion;
            this.SintonizadorTDT = SintonizadorTDT;
        }

        public void precioFinal()
        {
            base.PrecioFinal();

            if (this.Resolucion > 40)
            {
                base.PrecioBase = base.PrecioBase * 1.3;
            }

            if (this.SintonizadorTDT)
            {
                base.PrecioBase += 50;
            }
        }
    }
}