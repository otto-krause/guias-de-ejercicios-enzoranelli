using System.Collections.Generic;
namespace E5
{
    public abstract class SerPensante
    {
        protected List<string> Conocimiento = new List<string>();

        private int inteligencia;

        public int Inteligencia { get => inteligencia; set => inteligencia = value; }

        protected SerPensante(List<string> conocimiento, int inteligencia)
        {
            Conocimiento = conocimiento;
            Inteligencia = inteligencia;
        }
        public abstract void Pensar(string tema);
        public abstract void Estudiar(string tema);
        
    }
}