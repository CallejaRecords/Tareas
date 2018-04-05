using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class Tuner
    {
        int frecc;
        public void on()
        {
            Console.WriteLine("Tuner On");
        }
        public void off()
        {
            Console.WriteLine("Tuner Off");
        }
        public void setFrecuency(int f)
        {
            this.frecc = f;
            Console.WriteLine("Tuner frecuency at: " + frecc);
        }
    }
}
