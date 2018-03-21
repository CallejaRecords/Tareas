using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._9__Pizza_Store_
{
    class ChicagoLand: PizzaStore
    {
        public override string createPizza(Pizza p)
        {
            if (p.GetType() == typeof(Chicago))
            {
                Pizza pedido = p.crear(p);
                return pedido.descripcion();
            }
            else
            {
                return "No hay esa pizza";
            }
        }
    }
}
