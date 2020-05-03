namespace E5
{
    public class Producto
    {
        string nombre="";
        double precio=0;

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.Precio = precio;
        }

        public double Precio { get => precio; set => precio = value; }
    }
}