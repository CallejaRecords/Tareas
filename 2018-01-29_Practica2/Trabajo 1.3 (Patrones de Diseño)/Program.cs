using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._3__Patrones_de_Diseño_
{
    class Program
    {
        static void Main(string[] args)
        {
            var Apellido = new campoNombre();
            var celular = new campoTelefono();
            var hora = new campoHora();
            var fecha = new campoFecha();
            var email = new campoEamil();

            Console.WriteLine("Brian");
            string leerN = Console.ReadLine();
            Apellido.verificar(leerN);
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("123456789");
            string leerT = Console.ReadLine();
            celular.verificar("123456789");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("15:30:20");
            string leerH = Console.ReadLine();
            hora.verificar("15:30:20");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2018-01-29");
            string leerF = Console.ReadLine();
            fecha.verificar("2018-01-29");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("brian@cetys.com");
            string leerE = Console.ReadLine();
            email.verificar("brian@cetys.com");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
