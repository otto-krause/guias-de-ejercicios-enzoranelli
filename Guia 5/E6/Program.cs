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
            Pelicula pelicula10 = new Pelicula("Terminator","ciencia ficcion",1984,"James Cameron");

            List<Pelicula> peliculas = new List<Pelicula> {pelicula1, pelicula2, pelicula3, pelicula4, pelicula5, pelicula6, pelicula7, pelicula8, pelicula9, pelicula10};
            Peliteca peliteca = new Peliteca(peliculas);

            int salir=0;
            int opcion=0;

            while(salir!=7)
            {
                Console.WriteLine("Ingrese:\n[1]Para buscar pelicula por genero\n[2]Para buscar peliculas por nombre\n[3]Para buscar peliculas por año"+
                "\n[4]Para buscar peliculas por director\n[5]Para ver cuantas peliculas hay\n[6]Para ver cuantas peliculas hay por genero\n[7]Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        string genero;
                        Console.WriteLine("Ingrese el genero de pelicula que busca:");
                        genero= Console.ReadLine();
                        List<Pelicula> peliGenero = peliteca.peliculasPorGenero(genero);
                        if(peliGenero!=null)
                        {
                            Console.WriteLine("Peliculas de genero de "+genero+":");
                            peliGenero.ForEach(peli => Console.WriteLine(peli.Nombre+" de "+peli.Director));
                        }
                        else{
                            Console.WriteLine("No se encuentra peliculas del genero ingresado");
                        }
                    break;
                    case 2:
                        string nombre;
                        Console.WriteLine("Ingrese el nombre de pelicula que busca:");
                        nombre = Console.ReadLine();
                        List<Pelicula> peliNombre = peliteca.peliculasPorNombre(nombre);
                        if(peliNombre!=null)
                        {
                            Console.WriteLine("Peliculas encontradas:");
                            peliNombre.ForEach(peli => Console.WriteLine(peli.Nombre+" de "+peli.Director));
                        }
                        else{
                            Console.WriteLine("No se encuentra peliculas con el nombre ingresado");
                        }
                    break;
                    case 3:
                        int año=0;
                        Console.WriteLine("Ingrese un año para ver peliculas de ese mismo:");
                        año=Int32.Parse(Console.ReadLine());
                        List<Pelicula> peliAño = peliteca.peliculasPorAño(año);
                        if(peliAño!=null)
                        {
                            Console.WriteLine("Peliculas encontradas del año "+año+":");
                            peliAño.ForEach(peli => Console.WriteLine(peli.Nombre+" de "+peli.Director));
                        }
                        else{
                            Console.WriteLine("No se encuentra peliculas del año ingresado");
                        }
                    break;
                    case 4:
                        string director;
                        Console.WriteLine("Ingrese el nombre de un director para ver sus peliculas:");
                        director=Console.ReadLine();
                        List<Pelicula> peliDire = peliteca.peliculasPorDirector(director);
                        if(peliDire!=null)
                        {
                            Console.WriteLine("Peliculas del director "+director+":");
                            peliDire.ForEach(peli => Console.WriteLine(peli.Nombre+" del año "+peli.Año));
                        }
                        else{
                            Console.WriteLine("No se encontro peliculas del director ingresado");
                        }
                        break;
                    case 5:
                        Console.WriteLine("La cantidad de peliculas que hay en la peliteca es:"+peliteca.cuantasPelisHay());
                    break;
                    case 6:
                        Console.WriteLine("Ingrese un genero para ver su cantidad de peliculas:");
                        genero= Console.ReadLine();
                        Console.WriteLine("La cantidad de peliculas del genero de "+genero+" que hay en la peliteca es:"+peliteca.peliculasPorGeneroHay(genero));
                    break;
                    case 7:
                        salir=7;
                    break;

                }
            }
        }
    }
}
