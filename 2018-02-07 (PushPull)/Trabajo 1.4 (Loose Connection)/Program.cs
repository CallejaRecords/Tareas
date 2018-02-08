using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._4__Loose_Connection_
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new weatherData();
            float temp = 20;
            float humidity = 20;
            float pressure = 20;
            
            Observer display1 = new Display1();
            Observer display2 = new Display2();
            Observer display3 = new Display3();
            api.registerObserver(display1);
            api.registerObserver(display2);
            api.registerObserver(display3);
            api.removeObserver(display2);
            api.messurementChanged(temp, humidity, pressure);
            display1.display();
            display2.display();
            display3.display();
            Console.ReadLine();
        }
    }
}
