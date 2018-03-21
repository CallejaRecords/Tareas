using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Invoker
    {
        Command accion;
        static int bttn = 0;
        public void setCommand(Command c)
        {
            this.accion = c;
        }
        public void buttonPressed()
        {
            if (bttn == 0)
            {
                accion.execute();
                bttn = 1;
            }
            else
            {
                accion.undo();
                bttn = 0;
            }
        }
    }
}
