using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class campoEamil: CampoTexto
    {
        public campoEamil()
        {
            TipoTexto email = new Email();
            ponerTipo(email);
        }
        public override void verificar(string p)
        {
            base.verificar(p);
            Console.Write(" el email.");
        }
    }
}
