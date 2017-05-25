using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzos
{
    class TDAPata
    {
        private int cantidadPatas; 

        public TDAPata(int patas)
        {
            cantidadPatas = patas;
            Console.WriteLine("La cantidad de patas es: " + cantidadPatas + ".");
        }

        public int CantidadPatas
        {
            get
            {
                return cantidadPatas;
            }

            set
            {
                cantidadPatas = value;
            }
        }
    }
}
