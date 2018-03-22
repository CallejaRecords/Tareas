using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Invoker
    {
        List<Boton> botones = new List<Boton>();

        public void setCommand(Command c, int btn)
        {
            foreach (Boton bot in botones)
            {
                if (bot.idBtn == btn)
                {
                    bot.miAccion = c;
                }
            }
        }
        public void buttonPressed(int btn)
        {
            foreach (Boton bot in botones)
            {
                if (bot.idBtn == btn)
                {
                    if (bot.pressed == false)
                    {
                        bot.miAccion.execute();
                        bot.pressed = true;
                    }
                    else if (bot.pressed == true)
                    {
                        bot.miAccion.undo();
                        bot.pressed = false;
                    }
                    //if (bot.idBtn == 0)
                    //{
                    //    bot.miAccion.execute();
                    //}
                    //else if (bot.idBtn == 1)
                    //{
                    //    bot.miAccion.undo();
                    //}
                    else
                    {
                        Console.WriteLine("No se encontro boton");
                    }
                }
            }
        }
        public Invoker(int cantidadbt)
        {
            for (int x = 0; x < cantidadbt; x++)
            {
                botones.Add(new Boton(x));
            }
        } 
    }
}
