using System.Collections.Generic;
using System;
using System.Linq;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> persona = new List<Personas>();
            persona.Add(new Personas("Enzo","Ranelli",17));
            persona.Add(new Personas("Juan","Perez",17));
            persona.Add(new Personas("Ramiro","Perez",19));
            persona.Add(new Personas("Juan","Garcia",11));
            persona.Add(new Personas("Juan","Mitre",52));
            persona.Add(new Personas("Pedro","Perez",59));

            int salir=1;
            int opcion=0;

            while(salir==1)
            {
                Console.WriteLine("Ingrese un num para ver listas:\n[1]De mayores de edad\n[2]De personas con nombre Juan\n[3]De cantidad de Perez\n[4]Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                         Console.WriteLine("Personas mayores de edad");
                         persona.Where(persona => persona.Edad > 17)
                        .ToList()
                        .ForEach(persona => Console.WriteLine(persona.Nombre+ "  "+ persona.Apellido+" "+persona.Edad));
                        break;

                    case 2:
                        Console.WriteLine("Personas con nombre Juan");
                        persona.Where(persona => persona.Nombre == "Juan" )
                        .ToList()
                        .ForEach(persona => Console.WriteLine(persona.Nombre + " " + persona.Apellido + " " + persona.Edad));
                        break;
                    
                    case 3:
                        int CantidadPerez = persona.Count(persona => persona.Apellido == "Perez");
                        Console.WriteLine("La cantidad de personas con apellidos Perez son: "+CantidadPerez);
                        break;
                       
                    case 4:
                        salir=0;
                        break;
                    
                    default:
                        Console.WriteLine("El numero ingresado no coincide con ninguna opcion");
                        break;
                }
            }
        }
    }
}
