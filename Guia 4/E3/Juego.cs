namespace E3
{
    public class Juego
    {
        private string titulo;
        private int anoLanzamiento;
        private string consola;

        public Juego(string titulo, int anoLanzamiento, string consola)
        {
            this.Titulo = titulo;
            this.AnoLanzamiento = anoLanzamiento;
            this.Consola = consola;
        }

        public int AnoLanzamiento { get => anoLanzamiento; set => anoLanzamiento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Consola { get => consola; set => consola = value; }
    }
}