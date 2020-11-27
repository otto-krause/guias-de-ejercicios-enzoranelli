namespace E1
{
    public class Personas
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Personas(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public int Edad { get => edad; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;  }
    }
}