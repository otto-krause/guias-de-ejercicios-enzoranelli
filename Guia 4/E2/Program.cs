using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monstruos MikeWasaski= new MAmigable(0,"Mike");
            Monstruos Sully = new MPeligroso(0,"Sullyvan");
            Monstruos Randall = new MPeligroso(0,"Randall");
            List<Monstruos> Mostro = new List<Monstruos>();
            Mostro.Add(MikeWasaski);
            Mostro.Add(Sully);
            Mostro.Add(Randall);
            int salir =1;
            int energia=0;
            int opcion=0;      
            while(salir==1)
            {
                Console.WriteLine("Lista de puntos de respeto:"+
                " "+MikeWasaski.Nombre+": "+MikeWasaski.Respeto+
                ", "+Sully.Nombre+": "+Sully.Respeto+
                ", "+Randall.Nombre+": "+Randall.Respeto);
                Console.WriteLine("Ingrese:\n[1]Para la noche de sustos\n[2]Para la noches de risas\n[3]Para ver a los mas respetados"+
                "\n[4]Para ver la energia recolectada\n[5]Para salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("La noche de sustos ha comenzado!");
                        foreach(var i in Mostro)
                        {
                            i.Asustar();
                        }
                        break;
                    case 2:
                        Console.WriteLine("La noche de risas ha comenzado!");
                        foreach(var i in Mostro)
                        {
                            i.HacerReir();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Esta en la lista de los mounstruos mas respetados:");
                        foreach(var i in Mostro)
                        {
                            if(i.Respeto>70)
                            {
                                Console.WriteLine(i.Nombre);
                            }
                        }
                        break;
                    case 4:
                        foreach(var i in Mostro)
                        {
                            energia+=i.Respeto;
                        }
                        Console.WriteLine("La energia juntada es de "+energia);
                        break;
                    case 5:
                        salir=0;
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no pertenece a ninguna opcion");
                        break;
                }

            }
            
           
        }
    }
}
