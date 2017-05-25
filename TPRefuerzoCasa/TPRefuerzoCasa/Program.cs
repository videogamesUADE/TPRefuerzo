using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRefuerzoCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int c;
            Console.WriteLine("Ingrese la cantidad de ambientes que desea en su casa:");
            b = Convert.ToInt32(Console.ReadLine());
            Ambientes a = new Ambientes(b);
            Console.WriteLine("Ingrese la cantidad de ventanas que tendra cada ambietne:");
            c = Convert.ToInt32(Console.ReadLine());
            Ventanas v = new Ventanas(a.CantidadDeAmbiente, c);
            Puertas p = new Puertas(a.CantidadDeAmbiente);






            Console.WriteLine("La cantidad de Ambientes que tiene tu casa es " + a.CantidadDeAmbiente + ".\nLa cantidad de ventanas es: " + v.CantidadVentanas + ".\nLa cantidad de puertas es: " + p.CantidadPuertas + ".\n");








            Console.Read();
        }
    }
}
