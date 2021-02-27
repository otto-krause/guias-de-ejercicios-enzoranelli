using System.Collections.Generic;
using System.Linq;
namespace E6
{
    public class Peliteca
    {
        private List<Pelicula> peliculas;

        public Peliteca(List<Pelicula> peliculas)
        {
            this.peliculas = peliculas;
        }

        public List<Pelicula> peliculasPorGenero(string genero)
        {
            List<Pelicula>pelisXGenero = peliculas.Where(peli => peli.Genero.Contains(genero)).ToList();
            if(pelisXGenero.Count()>0)
            {
                return pelisXGenero;
            }
            else{
                return null;
            }
        }
        //public List<Pelicula> peliculasPorNombre(string nombre)
        //{

        //}
    }
}