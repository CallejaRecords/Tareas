using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Program
    {
        static void Main(string[] args)
        {
            Component cafeTaco = new Americano();
            Component cafeMalone = new Cafe();
            Component cafeMontaña = new Mocha();
            cafeMalone.size = "Wrande";
            int total2 = cafeMalone.cost();
            string descripcion2 = cafeMalone.getDescripcion();
            cafeTaco.size = "Wrande";
            cafeTaco = new Azucar(cafeTaco);
            cafeTaco = new Crema(cafeTaco);
            int total = cafeTaco.cost();
            string descripcion = cafeTaco.getDescripcion();
            cafeMontaña.size = "Mrande";
            cafeMontaña = new Chocolate(cafeMontaña);
            cafeMontaña = new Azucar(cafeMontaña);
            int total3 = cafeMontaña.cost();
            string descripcion3 = cafeMontaña.getDescripcion();
            Console.WriteLine(total);
            Console.WriteLine(descripcion);
            Console.WriteLine(total2);
            Console.WriteLine(descripcion2);
            Console.WriteLine(total3);
            Console.WriteLine(descripcion3);
            Console.ReadLine();
        }
    }
}
