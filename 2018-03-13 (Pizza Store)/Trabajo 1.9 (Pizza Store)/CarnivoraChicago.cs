using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class CarnivoraChicago : Pizza
    {
        public override string amazar(string p)
        {
            Console.WriteLine("Comenzando pizza de: " + p);
            Console.WriteLine("Se esta amazando la pizza");
            return "Maza";
        }

        public override string cortar(string p)
        {
            Console.WriteLine("La pizza se corto");
            return "Pizza cortada en 8";
        }

        public override string encajar(string p)
        {
            Console.WriteLine("La pizza esta lista y puesta en caja");
            return "Pizza Carnivora";
        }

        public override string hornear(string p)
        {
            Console.WriteLine("Se esta horneando la pizza");
            return "Pizza carnivora horneada";
        }

        public override string preparar(string p)
        {
            Console.WriteLine("Se estas poniendo ingredientes");
            return "Maza con salsa picosa y 4 carnes";
        }
    }
}
