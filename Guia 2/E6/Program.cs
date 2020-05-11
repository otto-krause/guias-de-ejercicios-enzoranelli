using System;
using System.Collections.Generic;
namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clasificacion> clasi = new List<Clasificacion>();
            clasi.Add(new Clasificacion(5,"Excelente"));
            clasi.Add(new Clasificacion(4,"Muy bueno"));
            clasi.Add(new Clasificacion(4,"Buenardo"));
            Juego HollowKnight = new Juego("Hollow Knight","Metroidvania",clasi);
            List<Clasificacion> clasi2 = new List<Clasificacion>();
            clasi2.Add(new Clasificacion(1,"Tiene muchos bugs"));
            clasi2.Add(new Clasificacion(2,"Es pay to win"));
            clasi2.Add(new Clasificacion(3,"Tiene algunas cosas buenas"));
            Juego CallOfDuty = new Juego("Call of duty","shooter",clasi2);
            List<Juego> juegos = new List<Juego>();
            juegos.Add(HollowKnight);
            juegos.Add(CallOfDuty);
            Steam steam = new Steam(juegos);
            int salir=1;
            int opcion=0;
            while(salir==1)
            {
                Console.WriteLine("Ingrese un n° para:\n[1]Buscar por Genero\n[2]Buscar por tipo de Clasificacion");
                opcion= Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        string genero="";
                        Console.WriteLine("Ingrese el genero que busca:");
                        genero = Console.ReadLine();
                        foreach(var i in steam.BuscarPorGenero(genero))
                        {
                            Console.WriteLine(i.Titulo);
                        }
                        break;
                    case 2:
                        string nota="";
                        Console.WriteLine("Ingrese el tipo de nota: ");
                        nota = Console.ReadLine();
                        foreach(var i in steam.BuscarPorCalificacion(nota))
                        {
                          Console.WriteLine(i.Titulo);
                        }
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                        break;    
                }
                Console.WriteLine("Ingrese 1 para continuar o otro n° para salir");
                salir=Int32.Parse(Console.ReadLine());
            }

           
          
            
            
        }
    }
}
