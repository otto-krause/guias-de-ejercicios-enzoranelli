namespace E1
{
    public class Pajaro : animal
    {
         public Pajaro(int energia) : base(energia)
        {
        }

        public override void Jugar()
        {
            Energia-=5;
        }
        public override void Comer()
        {
            Energia+=10;
        }
    }
}