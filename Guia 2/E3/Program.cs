using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();
            string nombre,posi,ps;
            int num;
            int opcion=0;
            int salir=1;
            while(salir==1)
            {
            Console.WriteLine("Ingrese para:\n[1]Ver cant. de delanteros\n[2]Ver cant. de mediocampistas\n[3]Agregar nueva figu\n[4]Ver si el album esta completo");
            opcion=Int32.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("La canti de delantero son: "+album.CuantosDelanteros());
                    break;
                case 2:
                    Console.WriteLine("La canti de mediocamp son: "+album.CuantosMediocampista());
                    break;
                case 3:
                    Console.WriteLine("Ingrese el pais");
                    ps= Console.ReadLine();
                    if (!album.EquipoLleno(ps))
                     {
                           Console.WriteLine("Ingrese el nombre del jugador");
                           nombre= Console.ReadLine();
                           Console.WriteLine("Ingrese la posicion del jugador");
                           posi = Console.ReadLine();
                           Console.WriteLine("Ingrese el numero de la figurita");
                           num = Int32.Parse(Console.ReadLine());
                           if(album.FiguritaRepetida(num))
                           {
                                album.setFigurita(nombre,posi,ps,num);
                                Console.WriteLine("La figurita fue agregada!");
                           }
                           else
                           {
                                Console.WriteLine("La figurita ingresada es repetida");   
                           }
                     }
                     else{
                         Console.WriteLine("La seleccion ingresada esta completa");
                     }           
                    break;
                case 4:    
                    if(album.AlbumLleno())
                    {
                        Console.WriteLine("El album esta lleno,¡FELICITACIONES!");
                    }
                    else
                    {
                        Console.WriteLine("El albun esta incompleto");
                    }
                    break;
                default:
                    Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                    break;                     
            }                     
            Console.WriteLine("Ingrese 1 para continuar o otro para salir");
            salir= Int32.Parse(Console.ReadLine());
            }
                 
        }
    }
}
