using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class Telefono : TipoTexto
    {
        public bool usTipo(string p)
        {
            
            bool result = Regex.Match(p, @"[0-9]{9}").Success;

            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        
    }
    }
}
