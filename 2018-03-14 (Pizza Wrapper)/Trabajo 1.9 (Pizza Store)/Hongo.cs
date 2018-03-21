using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class Hongo: Topings
    {
        Pizza preparando;
        public Hongo(Pizza p)
        {
            this.preparando = p;
        }
        public override string descripcion()
        {
            return (preparando.descripcion() + " hongo ");
        }
        public override Pizza preparar(Pizza p)
        {
            return preparando;
        }
    }
}
