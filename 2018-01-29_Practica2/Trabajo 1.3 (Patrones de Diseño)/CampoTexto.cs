using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class CampoTexto
    {
        public TipoTexto texto;

        public  void ponerTipo(TipoTexto T) {
            this.texto = T;
        }
        public virtual void verificar(string p) {
            bool verificado = texto.usTipo(p);
            Console.Write("Se ha verificado " + verificado);
        }
        
    }
}
