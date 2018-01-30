using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class Nombre : TipoTexto
    {

        public bool usTipo(string p)
        {
            bool result = p.All(Char.IsLetter);
            if (result == true){
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
