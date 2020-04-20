using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir=1;
            Celular xiaomi = new Celular(true,true,8000,5);
            while(salir==1)
            {
                int opcion=0;
                Console.WriteLine("Ingrese n° para:\n[1]ver memoria disponible\n[2]ver si puede cargar sube");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("La memoria del celular es :"+xiaomi.MemoriaDisponible());
                        break;
                    case 2:
                        Console.WriteLine("¿Puede cargar la SUBE? "+xiaomi.TeCargaLaSube());
                        break;    
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                        break;

                }
                Console.WriteLine("Ingrese 1 para continuar o otro para salir");
                salir = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
