using System.Collections.Generic;
namespace E3
{
    public class Jugador
    {
        private string nombre;
        private List<Consola> consolas;
        public Jugador(string nombre, List<Consola> consolas)
        {
            this.nombre = nombre;
            this.consolas = consolas;
        }
        public void AdquirirJuego(Juego game)
        {
            foreach(var i in consolas)
            {
                if(game.Consola==i.NombreDeconsola)
                {
                    i.Juegos.Add(game);
                }
            }
        }
        public string laMasUsada()
        {
            string consolausada="";
            int mayor=0;
            foreach(var i in consolas)
            {
                if(i.Puntaje()>mayor)
                {
                    mayor=i.Puntaje();
                    consolausada=i.NombreDeconsola;
                }
            }
            return consolausada;
        }
    }
}