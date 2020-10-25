using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            animal Perro1 = new Perro(100);
            animal Pajaro1 = new Pajaro(100);
            int salir=1;
            int opcion=0;
            while(salir==1)
            {
                Console.WriteLine("La energia del Perro es de:"+Perro1.Energia);
                Console.WriteLine("La enrgia del Pajaro es de:"+Pajaro1.Energia);
                Console.WriteLine("Ingrese:\n[1]Para jugar con Perro\n[2]Para jugar con Pajaro\n"+
                "[3]Para que Perro coma\n[4]Para que Pajaro coma\n[5]Para que Perro duerma\n[6]Para que Pajaro duerma\n[7]Para salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Perro1.Jugar();
                        Console.WriteLine("¡Perro ha jugado!");
                        break;
                    case 2:
                        Pajaro1.Jugar();
                        Console.WriteLine("¡Pajaro ha jugado!");
                        break;
                    case 3:
                        Perro1.Comer();
                        Console.WriteLine("¡Perro ha comido!");
                        break;
                    case 4:
                        Pajaro1.Comer();
                        Console.WriteLine("¡Pajaro ha comido!");
                        break;
                    case 5:
                        Perro1.Dormir();
                        Console.WriteLine("¡Perro ha dormido!");
                        break;
                    case 6:
                        Pajaro1.Dormir();
                        Console.WriteLine("¡Pajaro se ha dormido!");
                        break;
                    case 7:
                        salir=0;
                        break;
                    default:
                        Console.WriteLine("El num ingresado no pertenese a ninguna opcion");
                        break;
                }
            }
        }
    }
}
