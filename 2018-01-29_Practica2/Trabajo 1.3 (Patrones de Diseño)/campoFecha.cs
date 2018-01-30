using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class campoFecha: CampoTexto
    {
        public campoFecha()
        {
            TipoTexto fecha = new Fecha();
            ponerTipo(fecha);
        }
        public override void verificar(string p)
        {
            base.verificar(p);
            Console.Write(" la fecha.");
        }
    }
}
