namespace E2
{
    public class MAmigable : Monstruos
    {
        public MAmigable(int respeto, string nombre): base(respeto,nombre)
        {
        }

        public override void Asustar()
        {
            Respeto+=7;
        }
        public override void HacerReir()
        {
           Respeto+=1;
        }
    }
}