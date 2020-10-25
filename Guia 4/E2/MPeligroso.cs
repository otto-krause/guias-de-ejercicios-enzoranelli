namespace E2
{
    public class MPeligroso : Monstruos
    {
         public MPeligroso(int respeto, string nombre): base(respeto,nombre)
        {
        }
         public override void Asustar()
        {
            Respeto+=5;
        }
        public override void HacerReir()
        {
           Respeto-=2;
        }
    }
}