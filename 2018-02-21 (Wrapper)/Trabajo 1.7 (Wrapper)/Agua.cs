using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Agua: Decorator
    {
        Component bebida;
        public Agua(Component p)
        {
            this.bebida = p;
        }

        public override int cost()
        {
            return (2 + bebida.cost());
        }

        public override string getDescripcion()
        {
            return " Agua de manantial del cerro de tijuana";
        }
    }
}
