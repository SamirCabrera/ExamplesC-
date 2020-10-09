using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SamirC.POO.Vehiculos
{
    public abstract class Vehiculo
    {
        private string v;

        public string Matricula { get; private set; }
        public string Color { get; private set; }
        public string Marca { get; private set; }
        public int Km { get; private set; }
        public string Tipo { get; private set;}

        protected Vehiculo(string matricula, string color, string marca, int km, string tipo) 
        {
            Matricula = matricula;
            Color = color;
            Marca = marca;
            Km = km;
            Tipo = tipo;
        }

        protected Vehiculo(string v)
        {
            this.v = v;
        }
    }
}
