using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzos
{
    class TDACola
    {
        private float largoCola;

        public float LargoCola
        {
            get
            {
                return largoCola;
            }

            set
            {
                largoCola = value;
            }
        }

        public TDACola(float largo)
        {
            largoCola = largo;
            Console.WriteLine("El largo de la cola es " + largoCola + " mts.");
        }
    }
}
