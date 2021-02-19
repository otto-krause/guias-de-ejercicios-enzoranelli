using System.Collections.Generic;
namespace E2
{
    public class Supermercado
    {
        private List<carrito> carritos;

        public Supermercado(List<carrito> carritos)
        {
            this.carritos = carritos;
        }

        public int Ganancia()
        {
            int acu=0;
            foreach(var i in carritos)
            {
                acu+=i.PreciodeCarrito();
            }
            return acu;
        }
    }
}