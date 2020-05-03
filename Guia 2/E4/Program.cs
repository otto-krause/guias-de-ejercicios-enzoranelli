using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca peliteca = new Peliteca();
            string nombre="";
            int anio=0;
            string director="";
            string genero = "";
            int salir=1;
            int opcion=0;
            while(salir==1)
            {
                Console.WriteLine("Ingrese un N° para:\n1-Buscar peli por nombre\n2-Buscar peli por director\n3-Buscar por genero\n4-Buscar por año de pelicula\n5-Ver cuantas pelis hay\n6-Ver cuantas pelis hay X genero");
                opcion= Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de la pelicula: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Peliculas: ");
                        foreach(var i in peliteca.BuscarPorNombre(nombre))
                        {
                            Console.WriteLine(i.Nombre+" de "+i.Director+" [Año] "+i.Anio+" [genero]  "+i.Genero);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre del director:");
                        director = Console.ReadLine();
                        Console.WriteLine("Peliculas del director "+director+":");
                        foreach(var i in peliteca.BuscarPorDirector(director))
                        {
                            Console.WriteLine(i.Nombre+" [año] "+i.Anio+" [genero] "+i.Genero);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el genero que desea: ");                
                        genero = Console.ReadLine();
                        Console.WriteLine("Peliculas de genero de "+genero);
                        foreach(var i in peliteca.BuscarPorGenero(genero))
                        {
                             Console.WriteLine(i.Nombre+" de "+i.Director+" [Año] "+i.Anio);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el año de la pelicula que busca :");
                        anio=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Peliculas del año "+anio+":");
                        foreach(var i in peliteca.BuscarPorAnio(anio))
                        {
                            Console.WriteLine(i.Nombre+" de "+i.Director+" [genero] "+i.Genero);
                        }
                        break;
                    case 5:
                        Console.WriteLine("La cantidad de pelicula sque tiene la peliteca es de "+peliteca.CuantasPeliculasHay());
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el genero que desea: ");                
                        genero = Console.ReadLine();
                        Console.WriteLine("La cantidad de peliculas que tiene la peliteca es de "+peliteca.CuantasPelisPorGenero(genero));
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                        break;
                        
                }
                Console.WriteLine("Ingrese 1 para continuar o otro numero para salir: ");
                salir= Int32.Parse(Console.ReadLine());
            }
        }
    }
}
