using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class velocidadFanCommand: Command
    {
        CeilingFan fan;
        int velocidad;
        public velocidadFanCommand(CeilingFan f)
        {
            this.fan = f;
            this.velocidad = 0;
        }
        public void execute()
        {
            if (velocidad == 0)
            {
                fan.slow();
                velocidad = 1;
            }else if (velocidad == 1)
            {
                fan.medium();
                velocidad = 2;
            }else if (velocidad == 2)
            {
                fan.high();
                velocidad = 3;
            }else if (velocidad == 3)
            {
                fan.off();
                velocidad = 0;
            }
        }
        public void undo()
        {
            if (velocidad == 3)
            {
                fan.medium();
                velocidad = 2;
            }
            else if (velocidad == 2)
            {
                fan.slow();
                velocidad = 1;
            }
            else if (velocidad == 1)
            {
                fan.off();
                velocidad = 0;
            }
        }
    }
}
