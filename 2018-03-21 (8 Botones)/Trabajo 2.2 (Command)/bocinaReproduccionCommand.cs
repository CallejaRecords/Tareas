using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class bocinaReproduccionCommand: Command
    {
        Bocina bocina;
        public bocinaReproduccionCommand(Bocina p)
        {
            this.bocina = p;
        }
        public void execute()
        {
            bocina.reproduccionCancion(true);
        }

        public void undo()
        {
            bocina.reproduccionCancion(false);
        }
    }
}
