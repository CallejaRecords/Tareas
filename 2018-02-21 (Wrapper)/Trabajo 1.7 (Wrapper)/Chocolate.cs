using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Chocolate: Component
    {
        Component bebida;
        public Chocolate(Component p)
        {
            this.bebida = p;
        }

        public override int cost()
        {
            return (30 + bebida.cost());
        }

        public override string getDescripcion()
        {
            return (bebida.getDescripcion() + " Crema de la mas fina");
        }
    }
}
