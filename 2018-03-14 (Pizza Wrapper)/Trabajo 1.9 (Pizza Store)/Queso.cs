using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Queso: Topings
    {
        Pizza preparando;
        public Queso(Pizza p)
        {
            this.preparando = p;
        }
        public override string descripcion()
        {
            return (preparando.descripcion() + " queso ");
        }
        public override Pizza preparar(Pizza p)
        {
            return preparando;
        }
    }
}
