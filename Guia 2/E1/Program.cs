using System;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int num=1;
            while(num>0)
            {
                Console.WriteLine("Ingrese una lista de numeros distinta a cero:");
                num=Int32.Parse(Console.ReadLine());
                if(num>0)
                {
                    numeros.Add(num);
                }
            }
            Console.WriteLine("Los numeros de la lista son:");
            for (int i=0;i<numeros.Count;i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("\nLa cantidad de numeros que tiene la lista es: "+numeros.Count);
            Console.WriteLine("El primer numero de la lista es "+numeros[0]+" y el ultimo es "+numeros[numeros.Count-1]);
            Console.WriteLine("\nLos numeros mayores a 50 de esta lista son: ");
            for (int i = 0; i<numeros.Count;i++)
            {
                if(numeros[i]>50)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

        }
    }
}
