using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] vector = new int[10];
        int suma = 0;
        for (int i = 0; i<10 ; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            vector[i] = Int32.Parse(Console.ReadLine());
            
        }
        int salir = 1;
        int opcion = 0;
        while (salir==1)
        {
            Console.WriteLine("[1]Suma de elementos del vector\n[2]Promedio de elementos del vector\n[3]Menor elemento del vector\n[4]Ordenamiento de mayor a menor");
            opcion = Int32.Parse(Console.ReadLine());
            int i=0;
            int j=0;
            switch (opcion)
            {   
                case 1:
                    for (i = 0 ; i<10 ;i++)
                     {
                          suma += vector [i]; 
                     }
                      Console.WriteLine("La suma es :"+ suma);
                      break;
                case 2:
                    suma=0;
                     for (i = 0 ; i<10 ;i++)
                     {
                          suma += vector [i]; 
                     }
                     double promedio = 0;
                     promedio = suma/10;
                     Console.WriteLine("El promedio de los elementos es : "+promedio);
                     break;
                case 3:
                    int menor = 0;
                    for (i = 0 ; i<10 ; i++)
                    {
                        if (i == 0)
                        {
                            menor = vector [i];
                        }
                        else
                        {
                            if (vector[i] < menor)
                            {
                                menor = vector[i];
                            }
                        }
                    }  
                    Console.WriteLine("El elemento menor del vector es :"+ menor);
                    break;
                case 4:
                    int aux=0;
                    
                    for (i =0 ; i<10 ; i++)
                    {
                        for (j=i+1; j<10;j++)
                        {
                            if(vector[i] < vector[j])
                            {
                                aux=vector[i];
                                vector[i]=vector[j];
                                vector[j]=aux;
                            }
                         
                        }
                    }  
                    Console.WriteLine("Vector ordenado de mayor a menor:\n");
                    for( i=0; i<10 ; i++)
                    {
                        Console.WriteLine(vector[i]);
                    }
                    break;     
                default:
                    Console.WriteLine("\nEl numero ingresado no concuerda con ninguna opcion");               
                    break;         
            }
            
            
            Console.WriteLine("\nIngrese 1 para seleccionar otra opcion y cualquier otro numero para salir");
            salir = Int32.Parse(Console.ReadLine());

        }  
        }
    }
}
