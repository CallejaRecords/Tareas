using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Leche: Decorator
    {
        Component bebida;
        public Leche(Component p)
        {
            this.bebida = p;
        }

        public override int cost()
        {
            return (10 + bebida.cost());
        }

        public override string getDescripcion()
        {
            return " Leche de la vaca de mi casa";
        }
    }
}
