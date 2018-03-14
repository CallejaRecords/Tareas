using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Keto_s_Pizza: PizzaStore
    {
        public override string createPizza(string p)
        {
            if (p == "vegana")
            {
                Pizza vegana = new veganaKeto();
                return vegana.crear(p);
            }
            else
            {
                return "No existe esa pizza";
            }
        }
    }
}
