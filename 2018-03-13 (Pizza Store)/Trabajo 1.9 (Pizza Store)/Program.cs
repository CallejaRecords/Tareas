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
            PizzaStore chicago = new PizzaChicago();
            PizzaStore horno = new Horno420();
            PizzaStore keto = new Keto_s_Pizza();
            string pedido1 = chicago.orderPizza(chicago, "carnivoraChicago");
            string pedido2 = horno.orderPizza(horno, "peperoni");
            string pedido3 = keto.orderPizza(keto, "vegana");
            Console.Clear();
            Console.WriteLine("Pedido terminado pizza tipo: " + pedido1);
            Console.WriteLine("Pedido terminado pizza tipo: " + pedido2);
            Console.WriteLine("Pedido terminado pizza tipo: " + pedido3);
            Console.ReadLine();
        }
    }
}
