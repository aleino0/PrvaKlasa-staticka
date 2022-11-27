using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaKlasa_staticke
{
    class PrvaKlasa
    {
        private static int counter;

        public PrvaKlasa()
        {
            counter++;
        }

        public int Counter { get => counter; set => counter = value; }
    }
    class Program
    {
        static void Main()
        {
            PrvaKlasa x = new PrvaKlasa();
            PrvaKlasa y = new PrvaKlasa();
            PrvaKlasa z = new PrvaKlasa();

            Console.WriteLine("Vrijednost statičke varijable je: " + x.Counter);

            Console.ReadKey();
        }
    }
}
