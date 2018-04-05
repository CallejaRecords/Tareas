using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class Projector
    {
        public void on()
        {
            Console.WriteLine("Projector On");
        }
        public void off()
        {
            Console.WriteLine("Projector Off");
        }
        public void movieMode()
        {
            Console.WriteLine("Movie mode On");
        }
    }
}
