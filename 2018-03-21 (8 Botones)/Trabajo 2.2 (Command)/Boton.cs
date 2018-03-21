using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Boton
    {
        public int idBtn { get; set; }
        public bool pressed { get; set;}
        public Command miAccion { get; set; }
        public Boton(int id) {
            this.idBtn = id;
            this.pressed = false;
        }
    }
}
