using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._1__Personas_
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante = new Estudiante { nombre = "Brian", edad = 20, genero = true, matricula = 21088, carrera = "ICC", habilidad = };
            Console.WriteLine(estudiante.nombre + estudiante.edad + estudiante.genero + estudiante.matricula + estudiante.carrera);
            Console.ReadLine();
        }
    }
}
