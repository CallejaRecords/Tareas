using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class dvdPlayer
    {
        public void on()
        {
            Console.WriteLine("DVD On");
        }
        public void off()
        {
            Console.WriteLine("DVD Off");
        }
        public void play()
        {
            Console.WriteLine("Playing Movie");
        }
        public void eject()
        {
            Console.WriteLine("Ejecting Disc");
        }
    }
}
