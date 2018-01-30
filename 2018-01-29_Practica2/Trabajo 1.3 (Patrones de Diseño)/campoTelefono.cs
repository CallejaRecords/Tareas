using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class campoTelefono: CampoTexto
    {
        public campoTelefono()
        {
            TipoTexto telefono = new Telefono();
            ponerTipo(telefono);
        }
        public override void verificar(string p)
        {
            base.verificar(p);
            Console.Write(" el telefono.");
        }
    }
}
