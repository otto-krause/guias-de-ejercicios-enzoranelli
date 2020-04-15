using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gatito gaturro = new Gatito("gaturro",true,50);
            int salir = 1;
            int opcion=0;
            while (salir==1)
            {
                Console.WriteLine("Ingrese:\n[1]Para ver el nombre del gatito\n[2]Para ver si esta vacunado\n[3]Para jugar\n[4]Para darle de comer\n[5]Para ver si esta saludable");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("El nombre del gato es "+ gaturro.Nombre());
                        break;
                    case 2:
                        Console.WriteLine("¿El gato esta vacunado? "+ gaturro.estaVacunado());
                        break;
                    case 3:
                        int minutos=0;
                        Console.WriteLine("Ingrese cuantos minutos va a jugar con el gato");
                        minutos= Int32.Parse(Console.ReadLine());  
                        gaturro.Jugar(minutos);
                        Console.WriteLine("¡Has terminado de jugar!");
                        break;
                    case 4:
                        gaturro.comer();
                        Console.WriteLine("El gatito ha comido!");
                        break;
                    case 5:
                        Console.WriteLine("¿El gato es saludable? "+gaturro.estaSaludable());
                        break;
                    default:
                        Console.WriteLine("No has elegido ninguna opcion");
                        break;    

                }
                Console.WriteLine("La energia de "+gaturro.Nombre()+" es de "+gaturro.energy());
                Console.WriteLine("Ingrese 1 para elegir otras opciones o otro para salir: ");
                salir=Int32.Parse(Console.ReadLine());
            }
        }
    }
}
