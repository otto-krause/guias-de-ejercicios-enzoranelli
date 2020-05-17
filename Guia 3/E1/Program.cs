using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            PatoBalancin pato = new PatoBalancin();
            MrBurns burns = new MrBurns();

            Planta planta = new Planta(9001, homero, burns);
            int periodos=0;
            string opcion = "";
            do
            {
                periodos++;
                if (periodos%3 == 0)
                {
                    planta.BarrasDeUranio+=1000;
                    Console.WriteLine("LLEGARON CARGAMENTOS DE URANIO A LA PALNTA!");
                }
                    
                
                Console.WriteLine(
                "1)Ver si la planta esta en peligro\n" +
                "2)Homero come dona\n" +
                "3)Homero compra donas\n" +
                "4)Lenny toma cerveza\n" +
                "5)Cambiar empleado por Homero\n" +
                "6)Cambiar empleado por Lenny\n" +
                "7)Cambiar empleado por el Pato\n" +
                "8)Despojar a burns de sus riquezas");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.comer();
                        break;
                    case "3":
                        homero.comprar();
                        break;
                    case "4":
                        lenny.tomarCerverza();
                        break;
                    case "5":
                        planta.CambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.CambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.CambiarEmpleado(pato);
                        break;
                    case "8":
                        burns.despojarDeSusRiquezas();
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion != "salir");                               
        }
    }
}
