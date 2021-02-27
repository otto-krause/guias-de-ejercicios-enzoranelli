using System;
using System.Linq;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula1 = new Pelicula("Avatar","ciencia ficcion",2009,"James Cameron");
            Pelicula pelicula2 = new Pelicula("Terminator II","ciencia ficcion",1991,"James Cameron");
            Pelicula pelicula3 = new Pelicula("Tiburon","terror",1975,"Steven Spielberg");
            Pelicula pelicula4 = new Pelicula("El conjuro","terror",2013,"James Wan");
            Pelicula pelicula5 = new Pelicula("El lobo de wall street","drama",2013,"Martin Scorsese");
            Pelicula pelicula6 = new Pelicula("Bastardos sin gloria","accion",2009,"Quentin Tarantino");
            Pelicula pelicula7 = new Pelicula("Rescatando al soldado ryan","accion",1998,"Steven Spielberg");
            Pelicula pelicula8 = new Pelicula("Tiempos violentos","drama",1994,"Quentin Tarantino");
            Pelicula pelicula9 = new Pelicula("E.T","ciencia ficcion",1982,"Steven Spielberg");

            List<Pelicula> peliculas = new List<Pelicula> {pelicula1, pelicula2, pelicula3, pelicula4, pelicula5, pelicula6, pelicula7, pelicula8, pelicula9};
            Peliteca peliteca = new Peliteca(peliculas);

            string genero;
            Console.WriteLine("Ingreese el genero de pelicula que busca:");
            genero= Console.ReadLine();
            List<Pelicula> peliGenero = peliteca.peliculasPorGenero(genero);
            if(peliGenero!=null)
            {
                peliGenero.ForEach(peli => Console.WriteLine(peli.Nombre+" de "+peli.Director));
            }
            else{
                Console.WriteLine("No se encuentra peliculas del genero ingresado");
            }
        }
    }
}
