using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._6__Observer_Final_
{
    interface Subject
    {
        void registerObserver(Observer p);
        void removeObserver(Observer p);
        void notifyObserver();
        void timeExpired();
        void nuevoPaquete(int idCliente, string direccion, string nombre, int peso, string provedor);
    }
}
