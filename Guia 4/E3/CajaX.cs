using System.Collections.Generic;
namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(string nombreDeconsola, List<Juego> juegos, int puntos) : base (nombreDeconsola,juegos,puntos)
        {
        }

        public override void AgregarJuego(Juego game)
        {
            Juegos.Add(game);
            puntos+=25;
        }
        public override void Jugar(int horas)
        {
            puntos+=(4*horas);
        }
        public override int Puntaje()
        {
            return puntos;  
        }
    }
}