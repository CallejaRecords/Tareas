using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class Email : TipoTexto
    {
        public bool usTipo(string p)
        {
            try
            {
                MailAddress m = new MailAddress(p);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
