using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    abstract class PizzaStore
    {
        public string orderPizza(PizzaStore p, Pizza pizza)
        {
            return p.createPizza(pizza);

        }
        public abstract string createPizza(Pizza p);
    }
}
