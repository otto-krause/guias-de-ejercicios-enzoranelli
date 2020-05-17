using System;
using System.Collections.Generic;
namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor Waymayen = new Alfajor("negro",15,"Waymayen");
            Alfajor Jorgelin = new Alfajor("blanco",40,"Jorgelin");
            Alfajor Oreo = new Alfajor("triple oreo",50,"Oreo");
            List<Alfajor> alfajores = new List<Alfajor>();
            alfajores.Add(Waymayen);
            alfajores.Add(Jorgelin);
            alfajores.Add(Oreo);
            Argentina argentina = new Argentina(alfajores);

            int opcion=0;
            int salir=1;

            while(salir==1)
            {   
                Console.WriteLine("Lista de precio de alfajores: ");
                foreach(var i in argentina.Alfajores)
                {
                    Console.WriteLine("Alfajor: "+i.NombreDeEmpresa+" Precio: "+i.Precio);
                }
                Console.WriteLine("Ingrese un num para:\n[1]Bajar el precio del petróleo\n[2]Milllai habla por tv\n[3]CoronaVairas\n[4]Ver estado de inflacion"+
                "\n[5]Ver si argentina esta en dafault");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("El precio de petroleo bajo por el contexto economico mundial!");
                        argentina.BajarPrecioDePetroleo();
                        break;
                    case 2:
                        Console.WriteLine("Millai pronostica una hiper a fin de anio si no achican el estado en tv!");
                        argentina.MilllaiHablaPorTv();
                        break;
                    case 3: 
                        Console.WriteLine("[URGENTE] Aumenta los contagios en argentina por el coronavairas");
                        argentina.CoronaVairas();
                        break;
                    case 4:
                        Console.WriteLine("El estado de inflacion de argentina es :"+argentina.Inflacion());
                        break;
                    case 5:
                        if (argentina.Default())
                        {
                            Console.WriteLine("Argentina entro en default");
                        }        
                        else{
                            Console.WriteLine("Argentina No entro en default");
                        }
                        break;
                }
                Console.WriteLine("Ingrese 1 para continuar o otro num para salir");
                salir = Int32.Parse(Console.ReadLine());
            }

        }
    }
}
