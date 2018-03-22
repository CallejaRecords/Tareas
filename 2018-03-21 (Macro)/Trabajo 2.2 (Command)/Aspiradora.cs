using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Aspiradora
    {
        public void poderAspiradora(bool poder)
        {
            if (poder == true)
            {
                Console.WriteLine("Se prendio aspiradora");
            }
            else if (poder == false)
            {
                Console.WriteLine("Se apago aspiradora");
            }
        }
        public void modoAlfombra(bool modo)
        {
            if (modo == true)
            {
                Console.WriteLine("Modo alfombra On");
            }
            else if (modo == false)
            {
                Console.WriteLine("Modo alfomrba Off");
            }
        }
    }
}
