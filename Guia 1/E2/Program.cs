using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir=1;
            int opcion=0;
            int num1=0;
            int num2=0;
            while (salir==1)
            {
                Console.WriteLine("Ingrese:\n[1]Para multiplicar\n[2]Para dividir");
                opcion= Int32.Parse(Console.ReadLine());
                if (opcion==1)
                {   int producto=0;
                    Console.WriteLine("Ingrese un numero: ");
                    num1= Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero: ");
                    num2= Int32.Parse(Console.ReadLine());
                    for (int i=0;i<num2;i++)
                    {
                        producto+=num1;
                    }
                    Console.WriteLine("El resultado es :"+producto);
                }
                else
                {
                    if(opcion==2)
                    {
                        
                        int conciente=0;
                        int resto=0;
                        Console.WriteLine("Ingrese el dividendo: ");
                        num1= Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el divisor: ");
                        num2= Int32.Parse(Console.ReadLine());

                        if(num1>0 && num2>0)
                        {
                            resto=num1;
                            while(resto>=num2)
                            {
                                resto -= num2;
                                conciente++;
                            }
                            
                            Console.WriteLine(num1+" dividido "+num2+" es igual a "+conciente+" y el resto es "+resto);

                        }
                        else{
                            Console.WriteLine("Los numeros deben ser mayores a cero");
                        }
                        
                    }
                }
                Console.WriteLine("Ingrese [1] para elegir otra operacion o cualquier otro num para salir ");
                salir= Int32.Parse(Console.ReadLine());
            }
        }
    }
}
