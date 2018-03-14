using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore horno420 = new Horno420();
            PizzaStore ketos = new Ketos();
            PizzaStore chicagoL = new ChicagoLand();

            Pizza peperoni = new pepeHorno420();
            Pizza vegana = new Vegana();
            Pizza chicago = new Chicago();

            string pizza1 = horno420.orderPizza(horno420, peperoni);
            Console.WriteLine("Pedido terminado " + pizza1);
            Console.WriteLine();
            string pizza2 = ketos.orderPizza(ketos, vegana);
            Console.WriteLine("Pedido terminado " + pizza2);
            Console.WriteLine();
            string pizza3 = chicagoL.orderPizza(chicagoL, chicago);
            Console.WriteLine("Pedido terminado " + pizza3);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
