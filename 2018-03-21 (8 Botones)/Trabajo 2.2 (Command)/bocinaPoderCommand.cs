using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class bocinaPoderCommand: Command
    {
        Bocina bocina;
        public bocinaPoderCommand(Bocina p)
        {
            this.bocina = p;
        }
        public void execute()
        {
            bocina.poderBocina(true);
        }

        public void undo()
        {
            bocina.poderBocina(false);
        }
    }
}
