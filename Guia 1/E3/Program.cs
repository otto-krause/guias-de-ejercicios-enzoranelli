using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {   int num1=0;
            int salir=1;
            int opcion=0;
            while(salir==1)
            {
                Console.WriteLine("Ingrese un numero:");
                num1= Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese:\n [1] Para ver si su numero es primo\n[2] Para ver si es par");
                opcion= Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    
                    Program.Primo(num1);
                    
                }
                else{
                    if (opcion==2)
                    {
                        Program.Par(num1);
                    }
                    else{
                        Console.WriteLine("El numero no coincide con ninguna opcion");
                    }

                }
                Console.WriteLine("Ingrese [1] para ingresar otro numero o cualquier otro num para salir");
                salir= Int32.Parse(Console.ReadLine());
            }
            

           
        }
        static void Primo (int num1)
        {
             bool prim=true;
             for (int i=2; i < num1 && prim == true ; i++)
             {
                 if (num1 % i == 0)
                 {
                     prim=false;
                 }
             }
             if(!prim)
             {
                 Console.WriteLine("El numero "+num1+" no es primo");
             }
             else
             {
                 Console.WriteLine("El numero "+num1+" es primo");
             }
        }
        static void Par (int num1)
        {

          if(num1% 2 == 0)
          {
             Console.WriteLine("El numero "+num1+" es par");
          } 
          else{
              Console.WriteLine("El numero "+num1+" no es par");
          }

        }
    }
}
