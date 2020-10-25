namespace E1
{
    public abstract class animal
    {
        private int energia;

        public int Energia { get => energia; set => energia = value; }

        protected animal(int energia)
        {
            this.energia=energia;
        }

        public abstract void Jugar();
        public abstract void Comer();

        public void Dormir()
        {
            energia+=100;
        }
    }
}