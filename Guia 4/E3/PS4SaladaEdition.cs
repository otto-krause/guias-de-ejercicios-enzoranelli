using System.Collections.Generic;
namespace E3
{
    public class PS4SaladaEdition : Consola
    {
        public PS4SaladaEdition(string nombreDeconsola, List<Juego> juegos, int puntos) : base (nombreDeconsola,juegos,puntos)
        {
        }
        public override void AgregarJuego(Juego game)
        {
            Juegos.RemoveAt(0);
            Juegos.Add(game);
            puntos+=29;
        }
        public override void Jugar(int horas)
        {
            puntos+=(horas*3);
        }
        public override int Puntaje()
        {
            return puntos/2;  
        }
    }
}