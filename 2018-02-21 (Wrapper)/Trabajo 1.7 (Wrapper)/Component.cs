using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._7__Wrapper_
{
    abstract class Component
    {
        public string especificacion { get; set; }
        public string size { get; set; }

        public abstract int cost();
        public abstract string getDescripcion();

    }
}
