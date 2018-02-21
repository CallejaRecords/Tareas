using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    class Azucar : Decorator
    {
        Component bebida;
        public Azucar(Component p)
        {
            this.bebida = p;
        }

        public override int cost()
        {
            return (3 + bebida.cost());
        }

        public override string getDescripcion()
        {
            return (bebida.getDescripcion() +" Azucar de la mas fina");
        }
    }
}
