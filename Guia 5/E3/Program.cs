using System;
using System.Collections.Generic;
using System.Linq;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Armadura pegaso= new Armadura("pegaso","plata");
            Armadura dragon=new Armadura("dragon","esmeralda");
            Armadura caballo= new Armadura("caballo","plata");
            Armadura toro= new Armadura("toro","oro");
            caballeroDelZodiaco seiya = new caballeroDelZodiaco("Seiya","Atena","capricornio",pegaso);
            caballeroDelZodiaco goku = new caballeroDelZodiaco("Goku","Atena","cancer",dragon);
            caballeroDelZodiaco naruto = new caballeroDelZodiaco("Naruto","Hades","leo",caballo);
            caballeroDelZodiaco light = new caballeroDelZodiaco("Light","Zeus","virgo",toro);

            List<caballeroDelZodiaco> caballeros = new List<caballeroDelZodiaco> { seiya, goku, naruto, light};

            Console.WriteLine("Armaduras de caballeros que apoyen a Atena:");
            caballeros.Where(caballeros => caballeros.Dios1 == "Atena")
            .ToList()
            .ForEach(caballeros => Console.WriteLine("Armadura de "+caballeros.Nombre1+":Tiene material de "+caballeros.Armadura.Material1+" y su nombre es "+caballeros.Armadura.Nombre1));

            List<string> dioses = new List<string>();

            caballeros.ForEach(i => dioses.Add(i.Dios1));
            var diosesnorepeat = dioses.Distinct().ToList();

            Console.WriteLine("Lista de dioses:");
            diosesnorepeat.ForEach(diosesnorepeat => Console.WriteLine(diosesnorepeat));

            Console.WriteLine("Signos que empiecen con c:");
            caballeros.Where(caballeros => caballeros.SignoZodiacal.StartsWith("c"))
            .ToList()
            .ForEach(caballeros => Console.WriteLine(caballeros.SignoZodiacal));



        }
    }
}
