using System.Collections.Generic;
namespace E2
{
    public class carrito
    {
        private List<producto> productos;

        public carrito(List<producto> productos)
        {
            this.productos = productos;
        }

        public int PreciodeCarrito()
        {
            int acu=0;
            foreach(var i in productos)
            {
                acu+=i.Precio;
            }
            return acu;
        }
    }
}