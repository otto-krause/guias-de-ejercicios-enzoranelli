using System.Collections.Generic;
namespace E4
{
    public class Peliteca
    {
        List<Pelicula> peli = new List<Pelicula>();

        public Peliteca()
        {
            peli.Add(new Pelicula("Tiempos violentos","Suspenso",1994,"Quentin Tarantino"));
            peli.Add(new Pelicula("Bastardos sin Gloria","Accion",2009,"Quentin Tarantino"));
            peli.Add(new Pelicula("Avatar","Ciencia Ficcion",2009,"James Cameron"));
            peli.Add(new Pelicula("Terminator","Accion",1984,"James Cameron"));
            peli.Add(new Pelicula("Terminator II","Accion",1991,"James Cameron"));
        }
        public List<Pelicula> BuscarPorNombre(string nombre)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            foreach( var i in peli)
            {
                if (i.Nombre.Contains(nombre))
                    pelicula.Add(i);
            }
            return pelicula;
        }
        public List<Pelicula> BuscarPorDirector(string director)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            foreach( var i in peli)
            {
                if (i.Director.Contains(director))
                    pelicula.Add(i);
            }
            return pelicula;
        }
         public List<Pelicula> BuscarPorAnio(int anio)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            foreach( var i in peli)
            {
                if (i.Anio==anio)
                    pelicula.Add(i);
            }
            return pelicula;
        }
        public List<Pelicula> BuscarPorGenero(string genero)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            foreach( var i in peli)
            {
                if (i.Genero == genero)
                    pelicula.Add(i);
            }
            return pelicula;
        }
        public int CuantasPeliculasHay()
        {
            return peli.Count;
        }
        public int CuantasPelisPorGenero(string genero)
        {
            int cont=0;
            foreach (var i in peli)
            {
                if(i.Genero==genero)
                cont++;              
            }
            return cont;
        }
    }
}