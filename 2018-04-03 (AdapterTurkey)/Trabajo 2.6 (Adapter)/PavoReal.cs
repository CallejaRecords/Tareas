using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._6__Adapter_
{
    class PavoReal : iTurkey
    {
        public void kick()
        {
            Console.WriteLine("Super kick");
        }

        public void noice()
        {
            Console.WriteLine("Grlrlglrlglrl");
        }
    }
}
