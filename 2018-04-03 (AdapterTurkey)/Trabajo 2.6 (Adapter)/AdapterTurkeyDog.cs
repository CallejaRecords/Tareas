using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._6__Adapter_
{
    class AdapterTurkeyDog : iDog
    {
        iTurkey elpavo;
        public void bark()
        {
            elpavo.noice();
        }

        public void bite()
        {
            elpavo.kick();
        }
        public AdapterTurkeyDog(iTurkey t) {
            this.elpavo = t;
        }

    }
}
