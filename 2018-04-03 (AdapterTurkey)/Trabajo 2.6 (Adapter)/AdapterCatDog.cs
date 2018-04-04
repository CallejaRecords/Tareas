using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._6__Adapter_
{
    class AdapterCatDog : iDog
    {
        iCat elgato;
        public void bark()
        {
            elgato.purr();
        }

        public void bite()
        {
            elgato.slash();
        }
        public AdapterCatDog(iCat g)
        {
            this.elgato = g;
        }
    }
}
