using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    abstract class Pizza
    {
        public string crear(string p) {
            return encajar(cortar(hornear(preparar(amazar(p)))));
        }
        public abstract string amazar(string p);
        public abstract string preparar(string p);
        public abstract string hornear(string p);
        public abstract string cortar(string p);
        public abstract string encajar(string p);
    }
}
