﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Vegana: Pizza
    {
        public override string descripcion()
        {
            return " pizza de: ";
        }

        public override Pizza preparar(Pizza p)
        {
            p = new Salsa(p);
            p = new Hongo(p);
            p = new Jalapeno(p);
            return p;
        }
    }
}
