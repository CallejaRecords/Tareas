using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class campoNombre: CampoTexto
    {
        public campoNombre()
        {
            TipoTexto nombre = new Nombre();
            ponerTipo(nombre);
        }
        public override void verificar(string p)
        {
            base.verificar(p);
            Console.Write(" el nombre.");
        }
    }
}
