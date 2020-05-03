namespace E4
{
    public class Pelicula
    {
        string nombre;
        string genero;
        int anio;
        string director;

        public Pelicula(string nombre, string genero, int anio, string director)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Anio = anio;
            this.Director = director;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Director { get => director; set => director = value; }
    }
}