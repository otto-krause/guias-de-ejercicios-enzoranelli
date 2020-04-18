using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir=1;
            double a=0;
            double b=0;
            double c=0;
          
           
            int opcion=0;
            Console.WriteLine("Ingrese el lado A:");
            a = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el lado B:");
             b = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el lado C:");
             c = double.Parse(Console.ReadLine());
            triangulo triangulo1 = new triangulo (a,b,c); 
                
            while(salir==1)
            {
                Console.WriteLine("Ingrese un n° para:\n[1]Verificar triangulo equilatero\n[2]Verificar triangulo isoceles\n[3]Verificar triangulo escaleno\n[4]Verificar triangulo rectangulo");
                opcion = Int32.Parse(Console.ReadLine());
           
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("El triagulo es equilatero? "+triangulo1.EsEquilatero());
                        break;
                    case 2:
                        Console.WriteLine("El triangulo es isoceles? "+triangulo1.EsIsoceles());
                        break;
                    case 3:
                        Console.WriteLine("El triangulo es escaleno? "+triangulo1.EsEscaleno());
                        break;
                    case 4:
                        Console.WriteLine("El triangulo es rectangulo? "+triangulo1.EsTrianguloRectangulo());
                        break;
             
                
                    default:
                         Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                         break;
                }
               
                    Console.WriteLine("Ingrese 1 para continuar o otro numero para salir");
                    salir = Int32.Parse(Console.ReadLine());             
            }            
        }
    }
}
