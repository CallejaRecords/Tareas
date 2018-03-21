using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bocina bocina1 = new Bocina();
            bocinaCancionCommand cambiar = new bocinaCancionCommand(bocina1);
            bocinaPoderCommand poder = new bocinaPoderCommand(bocina1);
            Aspiradora aspiradora1 = new Aspiradora();
            aspiradoraPoderCommand poderA = new aspiradoraPoderCommand(aspiradora1);
            aspiradoraAlfombraCommand alfombra = new aspiradoraAlfombraCommand(aspiradora1);
            Invoker control = new Invoker();

            control.setCommand(cambiar);
            control.buttonPressed();
            control.buttonPressed();
            control.buttonPressed();
            control.setCommand(poder);
            control.buttonPressed();
            control.buttonPressed();
            control.buttonPressed();
            control.setCommand(poderA);
            control.buttonPressed();
            control.buttonPressed();
            control.buttonPressed();
            control.setCommand(alfombra);
            control.buttonPressed();
            control.buttonPressed();
            control.buttonPressed();
            Console.ReadLine();
        }
    }
}
