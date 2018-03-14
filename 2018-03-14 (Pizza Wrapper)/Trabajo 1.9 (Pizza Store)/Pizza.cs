using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    abstract class Pizza
    {
        public Pizza crear(Pizza p) {
            return encajar(cortar(hornear(preparar(amazar(p)))));
        }
        public abstract string descripcion();
        public abstract Pizza preparar(Pizza p);

        public Pizza amazar(Pizza p) {
            Console.WriteLine("Amazando");
            return p;
        }
        public Pizza hornear(Pizza p){
            Console.WriteLine("Horneando");
            return p;
        }
        public Pizza cortar(Pizza p){
            Console.WriteLine("Cortando");
            return p;
        }
        public Pizza encajar(Pizza p){
            Console.WriteLine("Empaquetando");
            return p;
        }
    }
}
