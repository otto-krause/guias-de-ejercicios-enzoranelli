namespace E7
{
    public class Alfajor
    {
        string nombre="";
        double precio=0;
        string nombreDeEmpresa = "";

        public Alfajor(string nombre, double precio, string nombreDeEmpresa)
        {
            this.nombre = nombre;
            this.Precio = precio;
            this.NombreDeEmpresa = nombreDeEmpresa;
        }

        public double Precio { get => precio; set => precio = value; }
        public string NombreDeEmpresa { get => nombreDeEmpresa; set => nombreDeEmpresa = value; }
    }
}