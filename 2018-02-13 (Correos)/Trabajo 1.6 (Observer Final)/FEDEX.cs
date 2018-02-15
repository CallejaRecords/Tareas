using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Trabajo_1._6__Observer_Final_
{
    class FEDEX: Subject
    {
        int id;
        private static Random r = new Random();
        List<Observer> Subscribers = new List<Observer>();
        List<Paquete> Paquetes = new List<Paquete>();
        Timer timer;

        public void notifyObserver()
        {
            foreach (Observer clientes in Subscribers)
            {
                foreach (Paquete pack in Paquetes)
                {
                    if (clientes.getID() == pack.idcliente)
                    {
                        clientes.update(pack);
                    }
                }
            }
        }

        public void registerObserver(Observer p)
        {
            Subscribers.Add(p);
        }

        public void removeObserver(Observer p)
        {
            Subscribers.Remove(p);
        }

        public void nuevoPaquete(int idCliente, string direccion, string nombre, int peso, string correo)
        {
            id = r.Next(100, 9000);
            int distancia = r.Next(0, 9000);
            Paquetes.Add(new Paquete(id, idCliente, direccion, nombre, peso, distancia, "FEDEX"));

        }
        public void timeExpired()
        {
            foreach (Paquete pack in Paquetes)
            {
                if (pack.distancia > 0)
                {
                    pack.distancia = pack.distancia - 10;
                }
                else { Paquetes.Remove(pack); }
            }
            notifyObserver();

        }
        public FEDEX()
        {
            timer = new Timer(1000);
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            notifyObserver();
            //Console.WriteLine("Entre");
        }
    }
}
