using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._4__Loose_Connection_
{
    class weatherData : Subject
    {
        float temp { get; set; }
        float humidity { get; set; }
        float pressure { get; set; }

        List<Observer> subscribers = new List<Observer>();

        public void notifyObserver()
        {
            foreach (Observer clientes in subscribers)
            {
                clientes.update(temp,humidity,pressure);
            }
        }

        public void registerObserver(Observer observer)
        {
            subscribers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            subscribers.Remove(observer);
        }
        public void messurementChanged(float temperatura, float humedad, float presion) {
            
            this.temp = temperatura;
            this.humidity = humedad;
            this.pressure = presion;
            notifyObserver();
        }
    

    }
}
