using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class cdPlayer
    {
        public void on()
        {
            Console.WriteLine("CD On");
        }
        public void off()
        {
            Console.WriteLine("CD Off");
        }
        public void play()
        {
            Console.WriteLine("Playing Music");
        }
        public void eject()
        {
            Console.WriteLine("Ejecting Disc");
        }
    }
}
