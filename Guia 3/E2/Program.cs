using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int salida=1;
            int horas=0;
            int acumulador=0;
            int presupuesto=0;
            List<contratista> empleados = new List<contratista>();
            empleados.Add(new pintores(0));
            empleados.Add(new pintores(0));
            empleados.Add(new Plomero(0));
            empleados.Add(new Plomero(0));
            empleados.Add(new Albanieles(true,60,0));
            empleados.Add(new Albanieles(false,25,0));
            while(salida==1)
            {
                int opcion=0;
                Console.WriteLine("Ingrese:\n[1]Para ingresar horas y presupuesto\n[2]Para salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de horas");
                        horas = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el presupuesto de la construccion");
                        presupuesto=Int32.Parse(Console.ReadLine());
                        foreach (var i in empleados)
                        {
                            i.trabajar(horas);
                        }
                        foreach(var i in empleados)
                        {
                            acumulador+=i.cobrar();
                        }
                        if(presupuesto>=acumulador)
                        {
                            Console.WriteLine("El proyecto puede llevarse a cabo");
                        }
                        else{
                            Console.WriteLine("El proyecto no puede llevarse a cabo debido a la falta de presupuesto");
                        }
                        break;
                    case 2:
                        salida=0;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                    
                }
            }        
        }
    }
}
