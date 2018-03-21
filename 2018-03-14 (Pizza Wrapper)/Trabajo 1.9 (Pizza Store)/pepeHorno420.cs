using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class pepeHorno420 : Pizza
    {
        
        public override string descripcion()
        {
            return " pizza de: ";
        }

        public override Pizza preparar(Pizza p)
        {
            p = new Salsa(p);
            p = new Queso(p);
            p = new Peperoni(p);
            return p;
        }
    }
}
