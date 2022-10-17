using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Videojuego
    {
        public String Titulo { get; set; } = "Macarrones con tomate";
        public Int16 HorasEstimadas { get; set; } = 10;
        public Boolean Entregado { get; set; } = false;
        public String Genero { get; set; } = "Terror";
        public String Companyia { get; set; } = "Manuelete";

        public Videojuego()
        {

        }

        public Videojuego(String Titulo, String Creador)
        {
            this.Titulo = Titulo;
            this.Companyia = Creador;
        }

        public Videojuego(string Titulo, short HorasEstimadas, string Genero, string Creador)
        {
            this.Titulo = Titulo;
            this.HorasEstimadas = HorasEstimadas;
            this.Genero = Genero;
            this.Companyia = Creador;
        }

        public override string ToString()
        {
            return $"Titulo: {this.Titulo}, horas estimadas: {this.HorasEstimadas}, entregado: {this.Entregado}, genero: {this.Genero}, compañía: {this.Companyia}.";
        }
    }
}