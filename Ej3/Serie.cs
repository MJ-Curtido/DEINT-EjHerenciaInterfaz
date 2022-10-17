using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Serie
    {
        public String Titulo { get; set; } = "El surfista programador";
        public Int16 NumTemp { get; set; } = 3;
        public Boolean Entregado { get; set; } = false;
        public String Genero { get; set; } = "Suspense";
        public String Creador { get; set; } = "Miguelito";

        public Serie()
        {

        }

        public Serie(String Titulo, String Creador)
        {
            this.Titulo = Titulo;
            this.Creador = Creador;
        }

        public Serie(string Titulo, short NumTemp, string Genero, string Creador)
        {
            this.Titulo = Titulo;
            this.NumTemp = NumTemp;
            this.Genero = Genero;
            this.Creador = Creador;
        }

        public override string ToString()
        {
            return $"Titulo: {this.Titulo}, numero de temporadas: {this.NumTemp}, entregado: {this.Entregado}, genero: {this.Genero}, creador: {this.Creador}.";
        }
    }
}