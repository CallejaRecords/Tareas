using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class bocinaCancionCommand : Command
    {
        Bocina bocina;
        public bocinaCancionCommand(Bocina p)
        {
            this.bocina = p;
        }
        public void execute()
        {
            bocina.cambiarCancion(true);
        }

        public void undo()
        {
            bocina.cambiarCancion(false);
        }
    }
}
