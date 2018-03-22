using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Bocina
    {
        public void poderBocina(bool poder)
        {
            if (poder == true)
            {
                Console.WriteLine("Se prendio bocina");
            }else if (poder == false)
            {
                Console.WriteLine("Se apago bocina");
            }
        }
        public void cambiarCancion(bool next)
        {
            if (next == true)
            {
                Console.WriteLine("Siguiente Cancion");
            }
            else if (next == false)
            {
                Console.WriteLine("Cancion Previa");
            }
        }
        public void reproduccionCancion(bool pausar)
        {
            if (pausar == true)
            {
                Console.WriteLine("Pausar Cancion");
            }
            else if (pausar == false)
            {
                Console.WriteLine("Reundar Cancion");
            }
        }
    }
}
