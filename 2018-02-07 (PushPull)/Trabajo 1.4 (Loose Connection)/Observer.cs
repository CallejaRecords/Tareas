using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._4__Loose_Connection_
{
    interface Observer
    {
        //void update(float temp, float humidity, float pressure);
        void update(Subject s, object dato);
        void display();
    }
}
