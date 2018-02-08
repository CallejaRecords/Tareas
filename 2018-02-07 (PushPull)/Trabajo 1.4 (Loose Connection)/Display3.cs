using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._4__Loose_Connection_
{
    class Display3 : Observer
    {
        float temperatura;
        float humedad;
        float presion;

        public void display()
        {
            float resultado = temperatura + humedad + presion;
            Console.WriteLine("Display 3 On: " + resultado);
        }

        public void update(Subject observando, object dato)
        {
            if (observando.GetType() == typeof(weatherData))
            {

                Console.WriteLine("entre");
                weatherData weather = new weatherData();
                this.temperatura = weather.temp;
                this.humedad = weather.humidity;
                this.presion = weather.pressure;
            }

        }
    }
}
