
using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            int num=0;
            int num1=0;
            int salir=1;
            while(salir==1)
            {
                int opcion=0;
                Console.WriteLine("Ingrese un n° para:\n[1]Fibonacci\n[2]Factorial\n[3]Para ver num menor\n[4]Para ver num mayor");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese numero: ");
                        num = Int32.Parse(Console.ReadLine());
                        for(int i =0;i<num;i++)
                        {
                            Console.Write(m.Fibonacci()+",");
                        }
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("ingrese numero: ");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es "+m.Factorial(num1));
                        break;
                    case 3:
                        Console.WriteLine("ingrese numero: ");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese otro numero: ");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El numero menor es :"+m.Menor(num,num1));
                        break;
                    case 4:
                        Console.WriteLine("ingrese numero: ");
                        num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese otro numero: ");
                        num = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El numero mayor es :"+m.Mayor(num,num1));
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                        break;    

                }
                Console.WriteLine("Ingrese [1] para continuar o cualquier otro para salir");
                salir= Int32.Parse(Console.ReadLine());

            }
            
        }
    }
}
