namespace E1
{
    public class Perro : animal
    {
        public Perro(int energia) : base(energia)
        {
        }

        public override void Jugar()
        {
            Energia-=20;
        }
        public override void Comer()
        {
            Energia+=15;
        }
    }
}