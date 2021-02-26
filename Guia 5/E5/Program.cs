using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> conocimientos = new List<string>();
            conocimientos.Add("Natacion");
            conocimientos.Add("Sumar");
            conocimientos.Add("Caminar");
            conocimientos.Add("Dormicion");
            conocimientos.Add("Persepcion");
            conocimientos.Add("Estudiar");
            conocimientos.Add("Comer");

            int salir=0;
            int opcion=0;

            while(salir!=4)
            {
                Console.WriteLine("Ingrese:\n[1]Para ver los ultimos 5 conocimientos\n[2]Los primeros 4 en orden alfabetico\n[3]Pensamientos terminados en -cion\n[4]Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Los ultimos 5 conocimientos son:");
                        foreach (var i in conocimientos.Skip(Math.Max(0, conocimientos.Count() - 5)))
                        {
                            Console.WriteLine(i);
                        }
                    break;

                    case 2:
                        List<string>pensamientosOrdenados = conocimientos.Select(pensamientos => pensamientos).Take(4).OrderBy(pensamientos => pensamientos).ToList();
                        Console.WriteLine("Los primeros pensamientos en orden alfabetico son:");
                        pensamientosOrdenados.ForEach(pensamiento => Console.WriteLine(pensamiento));
                    break;

                    case 3:
                        List<string>pensamientosCion = conocimientos.Where(conocimiento => conocimiento.EndsWith("cion")).ToList();
                        Console.WriteLine("Pensamientos terminados en -cion:");
                        pensamientosCion.ForEach(i => Console.WriteLine(i)); 
                    break;

                    case 4:
                        salir=4;
                    break;

                    default:
                        Console.WriteLine("No ha ingresado ninguna opcion.");
                        break;
                    
                }
            }
        }
    }
}
