using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        List<Producto> cliente = new List<Producto>();

        public Carrito(List<Producto> cliente)
        {
            this.cliente = cliente;
        }
        public double GananciaPorCarrito()
        {
            double ganancia=0;
            foreach(var i in cliente)
            {
                ganancia=+i.Precio;
            }
            return ganancia;
        }
    }
}