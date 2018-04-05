using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class Amplificador
    {
        Tuner tune;
        dvdPlayer dvd;
        cdPlayer cd;
        
        public void on()
        {
            Console.WriteLine("Amplificador On");
        }
        public void off()
        {
            Console.WriteLine("Amplificador Off");
        }
        public void setDVD(dvdPlayer d)
        {
            this.dvd = d;
        }
        public void setCD(cdPlayer c)
        {
            this.cd = c;
        }
        public void setTuner(Tuner t)
        {
            this.tune = t;
        }

    }
}
