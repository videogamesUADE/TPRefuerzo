using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzoCasa
{
    class Ventanas
    {
        private int cantidadVentanas;

        public Ventanas(int ambientes, int cantidad)
        {
            CantidadVentanas = ambientes * cantidad;
        }

        public int CantidadVentanas
        {
            get
            {
                return cantidadVentanas;
            }

            set
            {
                cantidadVentanas = value;
            }
        }
    }
}
