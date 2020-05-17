using System.Collections.Generic;
namespace E1
{
    public class Juego
    {
        string titulo;
        List<Calificacion> calificaciones;

        public Juego(string titulo, List<Calificacion> calificaciones)
        {
            this.titulo = titulo;
            this.calificaciones = calificaciones;
        }
    }
}