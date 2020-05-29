using System.Collections.Generic;
namespace E5
{
    public class Cyborg : SerPensante
    {
        List<string> Intereses = new List<string>();
        public Cyborg(List<string> conocimiento, List<string> intereses, int inteligencia) : base(conocimiento,inteligencia) 
        {
            Intereses = intereses;
        }

        public int Inteligencia1 { get => Inteligencia; set => Inteligencia = value; }

         public override void Pensar(string tema)
        {
            int puntos=0;
            puntos=Conocimiento.Count;
            foreach(var i in Conocimiento)
            {
                if (tema==i)
                    Inteligencia+=puntos;
            }
        }

           public override void Estudiar(string tema)
        {
            Conocimiento.Add(tema);
            foreach(var i in Intereses)
            {
                if (tema==i)
                    Inteligencia++;
            }
        }
    }
    
}