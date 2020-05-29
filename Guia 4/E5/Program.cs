using System;
using System.Collections.Generic;


namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intereses = new List<string>();
            List<string> conocimiento = new List<string>();
            conocimiento.Add("sumar");
            conocimiento.Add("restar");
            conocimiento.Add("multiplicar");
            conocimiento.Add("leer");
            conocimiento.Add("caminar");
            conocimiento.Add("programar");
            intereses.Add("musica");
            intereses.Add("videojuegos");
            intereses.Add("guitarra");
            intereses.Add("historia");
            intereses.Add("dibujar");
            intereses.Add("peliculas");
            intereses.Add("cine");
            intereses.Add("futbol");     
            SerPensante humano1 = new Humano(conocimiento,intereses,3);
            SerPensante robot1 = new Robot(conocimiento,1);
            SerPensante cyborg1 = new Cyborg(conocimiento,intereses,3);
            int salir=1;
            int opcion=0;
            string tema="";
            while(salir==1)
            {   
                Console.WriteLine("Inteligencia de humano:"+humano1.Inteligencia);
                Console.WriteLine("Inteligencia de robot:"+robot1.Inteligencia);
                Console.WriteLine("Inteligencia de cyborg:"+cyborg1.Inteligencia);
                Console.WriteLine("Ingrese:\n[1]Pensar con humano\n[2]Estudiar con hum\n[3]Pensar con robot\n[4]Estudiar con robot\n[5]Pensar con cyborg\n[6]Estudiar con cyborg");
                opcion= Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: 
                        Console.WriteLine("Ingrese un tema para pensar:");
                        tema= Console.ReadLine();
                        humano1.Pensar(tema);
                        Console.WriteLine("El humano ha pensado");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un tema para estudiar: ");
                        tema= Console.ReadLine();
                        Console.WriteLine("El humano ha estudiado");
                        humano1.Estudiar(tema);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un tema para pensar:");
                        tema= Console.ReadLine();
                        robot1.Pensar(tema);
                        Console.WriteLine("El robot ha pensado");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese un tema para estudiar: ");
                        tema= Console.ReadLine();
                        robot1.Estudiar(tema);
                        Console.WriteLine("El robot ha estudiado");
                        break;
                    case 5: 
                        Console.WriteLine("Ingrese un tema para pensar:");
                        tema= Console.ReadLine();
                        cyborg1.Pensar(tema);
                        Console.WriteLine("El cyborg ha pensado");
                        break;
                    case 6:
                         Console.WriteLine("Ingrese un tema para estudiar: ");
                        tema= Console.ReadLine();
                        cyborg1.Estudiar(tema);
                        Console.WriteLine("El cyrbog ha estudiado");
                        break;
                    default:
                        Console.WriteLine("La opcion no coincide con ningun numero");
                        break;
                }
                Console.WriteLine("Ingrese 1 para continuar otro num para salir");
                salir= Int32.Parse(Console.ReadLine());
            }
        }
    }
}
