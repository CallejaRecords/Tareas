using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._4__Loose_Connection_
{
    class Display1 : Observer
    {
        float temperatura;
        float humedad;
        float presion;
    
        public void display()
        {
            float resultado = temperatura + humedad + presion;
            Console.WriteLine("Display 1 On: " + resultado);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperatura = temp;
            this.humedad = humidity;
            this.presion = pressure;
        }
    }
}
