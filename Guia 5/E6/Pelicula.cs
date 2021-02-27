namespace E6
{
    public class Pelicula
    {
        private string nombre;
        private string genero;
        private int año;
        private string director;

        public Pelicula(string nombre, string genero, int año, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }

        public string Nombre { get => nombre;  }
        public string Genero { get => genero;  }
        public int Año { get => año;  }
        public string Director { get => director; }
    }
}