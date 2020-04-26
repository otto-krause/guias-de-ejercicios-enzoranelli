using System;



namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Clinica clinica = new Clinica();

            string especial;

            Console.WriteLine("Apicacion de turnos de hospital:");
            Console.WriteLine("Ingrese la especialidad que busca:");
            especial= Console.ReadLine();
            clinica.Turnos(especial);
            int nombres= 0;
            nombres=clinica.Turnos(especial).Length;
            if(nombres>1)
            {
                Console.WriteLine("El doctor que lo atendera es :"+clinica.Turnos(especial));
            }
            else{
                Console.WriteLine("No hay doctores disponibles para la especialidad que busca. Intente mas tarde");
            }
            

        }
    }
}
