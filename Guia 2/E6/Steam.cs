using System.Collections.Generic;
namespace E6
{
    public class Steam
    {
        List<Juego> juegos = new List<Juego>();

        public Steam(List<Juego> juegos)
        {
            this.juegos = juegos;
        }

        public List<Juego> BuscarPorGenero(string genero)
        {
            List<Juego> juegoGenero = new List<Juego>();
            foreach (var i in juegos)
            {
                if (i.Genero==genero)
                juegoGenero.Add(i);  
            } 
            return juegoGenero;
        }
        public List<Juego> BuscarPorCalificacion (string clasificacion)
        {
            List<Juego> juegoClas = new List<Juego>();
            foreach (var i in juegos)
            {
                if (i.TipoDeClasificacion()==clasificacion)
                juegoClas.Add(i);
            }
            return juegoClas;
        }

    }
}