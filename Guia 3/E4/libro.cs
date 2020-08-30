namespace E4
{
    public class libro
    {
        string autor;
        string titulo;

        public libro(string autor, string titulo)
        {
            this.Autor = autor;
            this.Titulo = titulo;
        }

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
}