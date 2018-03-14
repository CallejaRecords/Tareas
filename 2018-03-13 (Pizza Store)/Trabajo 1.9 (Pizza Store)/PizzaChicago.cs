﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class PizzaChicago : PizzaStore
    {
        public override string createPizza(string p)
        {
            if (p == "carnivoraChicago")
            {
                Pizza carnivora = new CarnivoraChicago();
                return carnivora.crear(p);
            }
            else
            {
                return "No existe esa pizza";
            }
        }
    }
}
