using System.Collections.Generic;
namespace E3
{
    public class PC : Consola
    {
        public PC(string nombreDeconsola, List<Juego> juegos, int puntos) : base (nombreDeconsola,juegos,puntos)
        {
        }
        public override void AgregarJuego(Juego game)
        {
            Juegos.Add(game);
        }
        public override void Jugar(int horas)
        {
            puntos+=(10*horas);
        }
        public override int Puntaje()
        {
            return puntos;  
        }
    }
}