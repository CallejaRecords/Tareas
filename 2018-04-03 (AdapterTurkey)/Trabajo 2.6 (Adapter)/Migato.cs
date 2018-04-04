using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._6__Adapter_
{
    class Migato : iCat
    {
        public void purr()
        {
            Console.WriteLine("Purrrrr");
        }

        public void slash()
        {
            Console.WriteLine("Slash face");
        }
    }
}
