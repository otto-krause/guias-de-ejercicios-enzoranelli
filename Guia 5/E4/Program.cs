using System;
using System.Collections.Generic;
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico doctor1 = new Medico("Enzo","Ranelli","clinico",53);
            Medico doctor2 = new Medico("Juan","Perez","dentista",49);
            Medico doctor3 = new Medico("Fulano","Garcia","clinico",89);
            Medico doctor4= new Medico("Ignacio","Fernandez","pediatra",5);
            List<Medico> medicos = new List<Medico> {doctor1, doctor2, doctor3, doctor4};
            Clinica clinica = new Clinica(medicos);

            int salir=0;

            while(salir!=2)
            {
                int opcion=0;
                Console.WriteLine("Ingrese:\n[1]Para buscar turno\n[2]Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        string especialidad;
                        Console.WriteLine("Ingrese la especialidad que desea:");
                        especialidad=Console.ReadLine();
                        Medico doctorturno = clinica.EstaDisponible(especialidad); 
                        if(doctorturno != null)
                        {
                            Console.WriteLine("El doctor que la atendera es:"+doctorturno.Nombre+" "+doctorturno.Apellido);
                        }
                        else{
                            Console.WriteLine("No se encuentra ningun doctor disponible. Intente mas tarde");
                        }
                    break;
                    case 2:
                        salir=2;
                    break;
                    default:
                        Console.WriteLine("No ha ingresado ninguna opcion");
                        break;
                }
            }
        }
    }
}
