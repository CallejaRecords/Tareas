using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Americano: Component
    {
        public override int cost()
        {
            if (this.size == "Wrande")
            {
                return 50;
            }else if (this.size == "Mrande")
            {
                return 35;
            }
            else
            {
                return 20;
            }
        }

        public override string getDescripcion()
        {
            return "Cafe con un poco de agua";
        }
    }
}
