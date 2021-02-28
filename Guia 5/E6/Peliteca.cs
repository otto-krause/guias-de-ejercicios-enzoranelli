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
            return null;

        }
        public List<Pelicula> peliculasPorNombre(string nombre)
        {
            List<Pelicula>pelisXNombre = peliculas.Where(peli => peli.Nombre.Contains(nombre)).ToList();
            if(pelisXNombre.Count()>0)
            {
                return pelisXNombre;
            }
            return null;
        }
        public List<Pelicula> peliculasPorAño(int año)
        {
            List<Pelicula> pelisXAño = peliculas.Where(peli => peli.Año == año).ToList();
            if(pelisXAño.Count()>0)
            {
                return pelisXAño;
            }
             return null;
        }
        public List<Pelicula> peliculasPorDirector(string director)
        {
            List<Pelicula> pelisXDirector = peliculas.Where(peli => peli.Director.Contains(director)).ToList();
            if(pelisXDirector.Count()>0)
            {
                return pelisXDirector;
            }
            return null;
        }
        public int cuantasPelisHay()
        {
            return peliculas.Count();
        }
        public int peliculasPorGeneroHay(string genero)
        { 
            return peliculasPorGenero(genero).Count();
        }
    }
}