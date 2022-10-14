using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Electrodomestico
    {
        private const Double PRECIO_BASE = 100, PESO = 5;
        private const Colores COLORES = Colores.BLANCO;
        private const Char CONSUMO = 'F';

        public Double PrecioBase { get; set; } = PRECIO_BASE;
        public Colores Colorado{ get; set; } = COLORES;
        public Char Consumo { get; set; } = CONSUMO;
        public Double Peso { get; set; } = PESO;

        public Electrodomestico()
        {

        }

        public Electrodomestico(Double PrecioBase, Double Peso)
        {
            this.PrecioBase = PrecioBase;
            this.Peso = Peso;
        }

        public Electrodomestico(Double PrecioBase, Colores Colorado, Char Consumo, Double Peso)
        {
            this.PrecioBase = PrecioBase;
            this.Colorado = ComprobarColor(Colorado);
            this.Consumo = ComprobarConsumoEnergia(Consumo);
            this.Peso = Peso;
        }

        public Char ComprobarConsumoEnergia(Char Letra)
        {
            if (Letra >= 'A' && Letra <= 'F')
            {
                return Letra;
            }
            else
            {
                return CONSUMO;
            }
        }

        public Colores ComprobarColor(Colores Colorado)
        {
            if (Enum.IsDefined(typeof(Colores), Colorado))
            {
                return Colorado;
            }
            else
            {
                return COLORES;
            }
        }

        public void PrecioFinal()
        {
            switch (Consumo)
            {
                case 'A':
                    this.PrecioBase += 100;
                    break;
                case 'B':
                    this.PrecioBase += 80;
                    break;
                case 'C':
                    this.PrecioBase += 60;
                    break;
                case 'D':
                    this.PrecioBase += 50;
                    break;
                case 'E':
                    this.PrecioBase += 30;
                    break;
                case 'F':
                    this.PrecioBase += 10;
                    break;
                default:
                    break;
            }

            switch (Peso)
            {
                case >= 79:
                    this.PrecioBase += 100;
                    break;
                case >= 49:
                    this.PrecioBase += 80;
                    break;
                case > 19:
                    this.PrecioBase += 50;
                    break;
                case >= 0:
                    this.PrecioBase += 10;
                    break;
                default:
                    break;
            }
        }
    }
}