namespace E2
{
    public class producto
    {
        private string nombre;

        private int precio;
        public producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public int Precio { get => precio; }
    }
}