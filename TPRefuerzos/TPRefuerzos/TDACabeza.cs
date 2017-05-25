using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzos
{
    class TDACabeza
    {
        private string tamaño;
        private int cantidadOjos;
        private int cantidadOrejas;
        private float melena;

        public int CantidadOjos
        {
            get
            {
                return cantidadOjos;
            }

            set
            {
                cantidadOjos = value;
            }
        }

        public int CantidadOrejas
        {
            get
            {
                return cantidadOrejas;
            }

            set
            {
                cantidadOrejas = value;
            }
        }

        public float Melena
        {
            get
            {
                return melena;
            }

            set
            {
                melena = value;
            }
        }

        public string Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
            }
        }

        public TDACabeza(string tamañoCabeza, int ojos, int orejas, float largoMelena)
        {
            tamaño = tamañoCabeza;
            cantidadOjos = ojos;
            cantidadOrejas = orejas;
            melena = largoMelena;
            Console.WriteLine("Tamaño de la cabeza: " + tamaño + ". \nCantidad de Ojos: " + cantidadOjos + ".\nCantidad de orejas: " + cantidadOrejas + ".\nEl largo de la melena: " + melena + ".");
        }
    }
}
