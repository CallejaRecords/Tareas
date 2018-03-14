using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Horno420: PizzaStore
    {
        public override string createPizza(string p)
        {
            if (p == "peperoni")
            {
                Pizza peperoni = new pepeHorno420();
                return peperoni.crear(p);
            }
            else
            {
                return "No existe esa pizza";
            }
        }
    }
}
