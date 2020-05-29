using System.Collections.Generic;
namespace E5
{
    public class Humano : SerPensante
    {
        List<string> Intereses = new List<string>();   
        public int Inteligencia1 { get => Inteligencia; set => Inteligencia = value; }
        public Humano(List<string> conocimiento, List<string> intereses, int inteligencia) : base(conocimiento,inteligencia)
        {
            Intereses = intereses;       
        }
        public override void Pensar(string tema)
        {   int largo=0;
            int cont=0;
            largo=Conocimiento.Count-5;
            foreach(var i in Conocimiento)
            {     
                if(cont>=largo)
                {
                    if(tema==i)
                        Inteligencia+=5;
                }
                cont++;
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