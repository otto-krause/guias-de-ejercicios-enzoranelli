using System.Collections.Generic;
using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Admin = new Administrador(35000);
            Empleado RH = new RRHH(5000,5);
            Empleado Junior = new Programador(30000,"Junior");
            Empleado Senior = new Programador(60000,"Senior");

            int salir = 1;
            int opcion =0;

            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(Admin);
            empleados.Add(RH);
            empleados.Add(Junior);
            empleados.Add(Senior);

            while(salir == 1)
            {   
                Console.WriteLine("Caja bancaria de empleados:");
                Console.WriteLine("RRHH: "+RH.CajaBancaria+" Admin: "+Admin.CajaBancaria+" Program Junior: "+Junior.CajaBancaria+" Senior: "+Senior.CajaBancaria);
                Console.WriteLine("Ingrese:\n[1]Para depositar\n[2]Para extraer\n[3]Para salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:                      
                        Console.WriteLine("[1]Admin\n[2]RRHH\n[3]Junior\n[4]Senior");
                        opcion=Int32.Parse(Console.ReadLine());                          
                        empleados[opcion-1].Depositar();
                        break;
                    case 2:
                        int monto=0;
                        Console.WriteLine("[1]Admin\n[2]RRHH\n[3]Junior\n[4]Senior");
                        opcion=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el monto");
                        monto=Int32.Parse(Console.ReadLine());
                        empleados[opcion-1].Extraer(monto);
                        break;
                    case 3:
                        salir=0;
                        break;
                    default:
                        Console.WriteLine("El n° ingresado no pertenece a ninguna opcion");
                        break;
                }
            }         
        }
    }
}
