using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
        private string nombreDeconsola;
        private List<Juego> juegos;
        protected int puntos;

        public string NombreDeconsola { get => nombreDeconsola; set => nombreDeconsola = value; }
        public List<Juego> Juegos { get => juegos; set => juegos = value; }

        protected Consola(string nombreDeconsola, List<Juego> juegos, int puntos)
        {
            this.nombreDeconsola = nombreDeconsola;
            this.Juegos = juegos;
            this.puntos = puntos;
        }

        public abstract void AgregarJuego(Juego game);
        public abstract void Jugar(int horas);
        public abstract int Puntaje();
        public string elMasViejo()
        {
            int viejo=0;
            viejo=Juegos[0].AnoLanzamiento;
            string titulo="";
            foreach(var i in Juegos)
            {
                if(i.AnoLanzamiento<viejo)
                {
                    viejo=i.AnoLanzamiento;
                    titulo=i.Titulo;
                }        
            }
            return titulo;
        }
        public string elMasNuevo()
        {
            int nuevo=0;
            string titulo="";
            foreach(var i in Juegos)
            {
                if(i.AnoLanzamiento>nuevo)
                {
                    nuevo=i.AnoLanzamiento;
                    titulo=i.Titulo;
                }
            }
            return titulo;
        }
    }
}