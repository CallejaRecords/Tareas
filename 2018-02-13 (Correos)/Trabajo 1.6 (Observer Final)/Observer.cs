using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._6__Observer_Final_
{
    interface Observer
    {
        void update(Paquete o);
        void paquete(int peso, Subject provedor);
        void display();
        int getID();
        string getName();
        
    }
}
