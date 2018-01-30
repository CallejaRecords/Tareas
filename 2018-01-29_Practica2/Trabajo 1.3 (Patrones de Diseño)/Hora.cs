using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class Hora : TipoTexto
    {
        public bool usTipo(string p)
        {
            DateTime datetime;
            bool result = DateTime.TryParseExact(p, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out datetime);

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
