using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._6__Adapter_
{
    class Program
    {
        static void Main(string[] args)
        {
            Migato gato = new Migato();
            PavoReal pavo = new PavoReal();
            AdapterCatDog catdog = new AdapterCatDog(gato);
            AdapterTurkeyDog pavoperro = new AdapterTurkeyDog(pavo);

            catdog.bark();
            catdog.bite();
            pavoperro.bark();
            pavoperro.bite();
            Console.ReadLine();
        }
    }
}
