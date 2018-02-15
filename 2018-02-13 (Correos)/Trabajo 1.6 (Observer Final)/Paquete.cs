using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._6__Observer_Final_
{
    class Paquete
    {
        public int id { get; set; }
        public int idcliente { get; set; }
        public int peso { get; set; }
        public string provedor { get; set; }
        public double distancia { get; set; }
        public string direccion { get; set; }
        public string nombre { get; set; }

        public Paquete(int id, int CId, string dir, string nombre, int peso, double distancia, string prov)
        {
            this.id = id;
            this.direccion = dir;
            this.nombre = nombre;
            this.idcliente = CId;
            this.peso = peso;
            this.distancia = distancia;
            this.provedor = prov;
        }
    }
   
}
