using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeTheater theather = new FacadeTheater();
            theather.watchMovie();
            Console.ReadLine();
            Console.Clear();
            theather.stopWatching();
            Console.ReadLine();
            Console.Clear();
            theather.listenMusic();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
