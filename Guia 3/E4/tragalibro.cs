using System.Collections.Generic;

namespace E4
{
    public class tragalibro
    {
        List<libro> librosleidos = new List<libro>();

        public void Leer(libro libro)
        {
            int acu=0;
            if(librosleidos.Count == 0)
            {
                librosleidos.Add(libro);
            }
            foreach(var i in librosleidos)
            {
                if(i.Autor != libro.Autor)
                {
                    acu++;
                    if(i.Titulo != libro.Titulo)
                    {
                        acu++;
                    }
                }
            }
            if(acu/2 == librosleidos.Count)
                librosleidos.Add(libro);
        }
        public int CalcularCI()
        {
            return librosleidos.Count*5;
        }
    }
}