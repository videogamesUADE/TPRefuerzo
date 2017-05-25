using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzoCasa
{
    class Puertas
    {
        private int cantidadPuertas;

        public Puertas(int ambientes)
        {
            CantidadPuertas = ambientes + 1;
        }

        public int CantidadPuertas
        {
            get
            {
                return cantidadPuertas;
            }

            set
            {
                cantidadPuertas = value;
            }
        }
    }
}
