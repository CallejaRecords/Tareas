using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._6__Observer_Final_
{
    class Program
    {
        static void Main(string[] args)
        {
            var dhl = new DHL();
            var defex = new FEDEX();

            var mexico = new CoreosMexico();
            var Brian = new Cliente1("Brian", "La Montaña");
            dhl.registerObserver(Brian);
            defex.registerObserver(Brian);
            mexico.registerObserver(Brian);
            Brian.paquete(69,dhl);
            Brian.paquete(70, defex);
            Brian.paquete(71, mexico);
            //Observer cliente1 = new Cliente1();
            //dhl.registerObserver(cliente1);
            //defex.registerObserver(cliente1);
            //mexico.registerObserver(cliente1);
            //cliente1.paquete(dhl);
            //cliente1.paquete(defex);
            //cliente1.paquete(mexico);
            //cliente1.paquete(dhl);
            //cliente1.display();
            Console.ReadLine();
        }
    }
}
