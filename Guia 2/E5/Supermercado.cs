using System.Collections.Generic;
namespace E5
{
    public class Supermercado
    {
      
        List <Carrito> carritos = new List<Carrito>();

     
        public double GananciasTotales()
        {
            double ganancias=0;
            foreach(var i in carritos)
            {
                ganancias=+i.GananciaPorCarrito();
            }
            return ganancias;
        }
    }
}