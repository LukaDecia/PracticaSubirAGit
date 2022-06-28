using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPav
{
    public class Jugador
    {

        private int Id ;
        private string Nombre;
        private int Edad;

        public Jugador()
        {

        }

        public Jugador(int id, string nombre)
        {
            Id1 = id;
            Nombre1 = nombre;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
    }
}
