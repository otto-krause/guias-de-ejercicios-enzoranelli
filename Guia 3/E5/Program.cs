using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman megaman= new Megaman();
            int opcion=0;
            while(opcion<4)
            {
                Console.WriteLine("Ingrese:\n[1]Para ver fuerza\n[2]Para entrenar\n[3]Cambiar Armadura\n[4]Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("La fureza de megaman x es de "+megaman.fuerza()+" puntos.");
                        break;
                    case 2:
                        int minutos=0;
                        Console.WriteLine("Ingrese los minutos de entrenamiento");
                        minutos=Int32.Parse(Console.ReadLine());
                        megaman.entrenar(minutos);
                        Console.WriteLine("Megaman ha entrenado!");
                        break;
                    case 3:    
                        megaman.cambiarArmadura();
                        Console.WriteLine("Megaman X cambio su armadura Falcon Armor a Shadow Armor");
                        break;
                    default:
                        Console.WriteLine("Hasta luego!");
                        break;
                }
            }

        }
    }
}
