using System;
using System.Collections.Generic;
using System.Text;

namespace SamirC.POO.Vehiculos
{
    class Bus : Vehiculo
    {
        public int Puestos { get; private set; }
        public int NumPasajeros { get; private set; }
        public Bus(int puestos, int numPsajeros) : base(nameof(Bus))
        {
            Puestos = puestos;
            NumPasajeros = numPsajeros;
        }

        public int CalcularPuestosDisponibles()
        {
            return Puestos - NumPasajeros;
        };
    }
}
