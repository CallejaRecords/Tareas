using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class CeilingFan
    {
        public void off()
        {
           Console.WriteLine("Se apago el ceiling fan");
        }
        public void slow()
        {
            Console.WriteLine("Velocidad Slow");
        }
        public void medium()
        {
            Console.WriteLine("Velocidad medium");
        }
        public void high()
        {
            Console.WriteLine("Velocidad high");
        }
    }
}
