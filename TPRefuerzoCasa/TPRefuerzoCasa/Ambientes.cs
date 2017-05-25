using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzoCasa
{
    class Ambientes
    {
        private int cantidadDeAmbiente;

        public Ambientes(int cantidad)
        {
            CantidadDeAmbiente = cantidad;
        }

        public int CantidadDeAmbiente
        {
            get
            {
                return cantidadDeAmbiente;
            }

            set
            {
                cantidadDeAmbiente = value;
            }
        }
    }
}
