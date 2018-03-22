using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class aspiradoraAlfombraCommand: Command
    {
        Aspiradora aspiradora;
        public aspiradoraAlfombraCommand(Aspiradora a)
        {
            this.aspiradora = a;
        }
        public void execute()
        {
            aspiradora.modoAlfombra(true);
        }

        public void undo()
        {
            aspiradora.modoAlfombra(false);
        }
    }
}
