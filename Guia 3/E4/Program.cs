using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            libro libro1 = new libro("Aldous Huxley","Un mundo feliz");
            libro libro2 = new libro("Arthur Doyle","La liga de los pelirrojos");
            libro libro3 = new libro("Aldous Huxley","Un mundo feliz");
            libro libro4 = new libro("Mafalda","Quino");

            tragalibro tragalibro = new tragalibro();

            tragalibro.Leer(libro1);
            tragalibro.Leer(libro2);
            tragalibro.Leer(libro3);
            tragalibro.Leer(libro3);  
            tragalibro.Leer(libro4);  


            int intelectual = tragalibro.CalcularCI();

            Console.WriteLine("porque "+intelectual);

        }
    }
}
