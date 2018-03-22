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
            bocinaCancionCommand cambiarB1 = new bocinaCancionCommand(bocina1);
            bocinaPoderCommand poderB1 = new bocinaPoderCommand(bocina1);
            bocinaReproduccionCommand reproduccionB1 = new bocinaReproduccionCommand(bocina1);

            Bocina bocina2 = new Bocina();
            bocinaCancionCommand cambiarB2 = new bocinaCancionCommand(bocina2);
            bocinaPoderCommand poderB2 = new bocinaPoderCommand(bocina2);
            bocinaReproduccionCommand reproduccionB2 = new bocinaReproduccionCommand(bocina2);

            Aspiradora aspiradora1 = new Aspiradora();
            aspiradoraPoderCommand poderA1 = new aspiradoraPoderCommand(aspiradora1);
            aspiradoraAlfombraCommand alfombraA1 = new aspiradoraAlfombraCommand(aspiradora1);

            CeilingFan fan1 = new CeilingFan();
            velocidadFanCommand velocidad1 = new velocidadFanCommand(fan1);

            macroCommand1 macro1 = new macroCommand1();


            Invoker controlUniversal = new Invoker(8);
            controlUniversal.setCommand(cambiarB1, 0);
            //controlUniversal.setCommand(velocidad1, 0);
            //controlUniversal.setCommand(velocidad1, 1);
            controlUniversal.setCommand(poderB1, 1);
            controlUniversal.setCommand(reproduccionB1, 2);
            //controlUniversal.setCommand(cambiarB2, 3);
            //controlUniversal.setCommand(poderB2, 4);
            controlUniversal.setCommand(macro1, 3);
            controlUniversal.setCommand(reproduccionB2, 5);
            controlUniversal.setCommand(poderA1, 6);
            controlUniversal.setCommand(alfombraA1, 7);

            macro1.addMacro(poderB1);
            macro1.addMacro(poderA1);
            macro1.addMacro(alfombraA1);

            //controlUniversal.buttonPressed(0);
            //controlUniversal.buttonPressed(0);
            //controlUniversal.buttonPressed(0);
            //Console.ReadLine();
            //Console.Clear();
            //controlUniversal.buttonPressed(1);
            //controlUniversal.buttonPressed(1);
            //controlUniversal.buttonPressed(1);
            //Console.ReadLine();
            //Console.Clear();
            //controlUniversal.buttonPressed(2);
            //controlUniversal.buttonPressed(2);
            //controlUniversal.buttonPressed(2);
            //Console.ReadLine();
            //Console.Clear();
            controlUniversal.buttonPressed(3);
            Console.ReadLine();
            controlUniversal.buttonPressed(3);
            Console.ReadLine();
            macro1.removeMacro(poderA1);
            macro1.removeMacro(alfombraA1);
            controlUniversal.buttonPressed(3);
            Console.ReadLine();
            macro1.resetMacro();
            controlUniversal.buttonPressed(3);
            Console.ReadLine();
       
            //Console.Clear();
            //controlUniversal.buttonPressed(4);
            //controlUniversal.buttonPressed(4);
            //controlUniversal.buttonPressed(4);
            //Console.ReadLine();
            //Console.Clear();
            //controlUniversal.buttonPressed(5);
            //controlUniversal.buttonPressed(5);
            //controlUniversal.buttonPressed(5);
            //Console.ReadLine();
            //Console.Clear();
            //controlUniversal.buttonPressed(6);
            //controlUniversal.buttonPressed(6);
            //controlUniversal.buttonPressed(6);
            //Console.ReadLine();
            //Console.Clear();
            //controlUniversal.buttonPressed(7);
            //controlUniversal.buttonPressed(7);
            //controlUniversal.buttonPressed(7);
            //Console.ReadLine();
            Console.Clear();
        }
    }
}
