using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._1__Personas_
{
    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public bool genero { get; set; }

        public IMotriz brazoD = new BrazoD();
        public IMotriz piernaD = new PiernaD();

        public void respirar() { }

        public void moverbrazoD()
        {
            brazoD.Mover();
        }
        public void moverpiernaD()
        {
            piernaD.Mover();
        }
    }
}
