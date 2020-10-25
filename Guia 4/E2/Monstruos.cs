namespace E2
{
    public abstract class Monstruos
    {
        private int respeto;
        private string nombre;

        public int Respeto { get => respeto; set => respeto = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        protected Monstruos(int respeto, string nombre)
        {
            this.respeto=respeto;
            this.nombre=nombre;
        }

        public abstract void Asustar();
        public abstract void HacerReir(); 
    }
}