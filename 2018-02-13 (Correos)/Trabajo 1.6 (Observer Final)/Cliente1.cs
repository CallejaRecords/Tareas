using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._6__Observer_Final_
{
    class Cliente1 : Observer
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        private static Random r = new Random();
        public int idcliente { get; set; }
        public Cliente1(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            idcliente = r.Next(100,9999);
        }
        public void paquete(int peso, Subject o)
        {
            o.nuevoPaquete(idcliente, Direccion, Nombre, peso, o.ToString());
        }

        public void update(Paquete o)
        {
            if (o.distancia < 100)
            {
                Console.WriteLine("Producto recibido");
                Console.WriteLine("Actualizacion Paquete con ID:{0} \n Nombre del destinatario: {1} \n Peso del paquete{2} \n Recibida \n Proveedor: {3} \n", o.id, o.nombre, o.peso, o.provedor);
            }
            else
            {
                Console.WriteLine("Actualizacion Paquete con ID:{0} \n Nombre del destinatario: {1} \n Peso del paquete: {2} \n Distancia hasta el punto de envio: {3} km \n Proveedor: {4} \n", o.id, o.nombre, o.peso, o.distancia, o.provedor);
            }

            Console.ResetColor();

        }
        public void display()
        {
            //foreach (string pack in paquetes)
            //{
            //    Console.WriteLine("Cliente 1 pedi paquete " + pack);
            //}
        }

        public int getID()
        { return this.idcliente; }
        public string getName()
        { return this.Nombre; }
        public string getDireccion()
        { return this.Direccion; }
    }
}
