using System.Collections.Generic;
namespace E5
{
    public class Robot : SerPensante
    {
        public Robot(List<string> conocimiento, int inteligencia) : base(conocimiento,inteligencia)
        {  
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
        }
    }
}