using System;
using System.Collections.Generic;
using System.Text;

namespace SamirC.POO.Vehiculos
{
    class Camion : Vehiculo
    {
        public string TipoCarga { get; private set; }
        public double KgCarga { get; private set; }
        public Camion(string tipoCarga, double kgCarga) : base(nameof(Camion))
        {
            TipoCarga = tipoCarga;
            KgCarga = kgCarga;
        }
    }
}
