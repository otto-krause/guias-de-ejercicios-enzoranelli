namespace E5
{
    public class Megaman
    {
        int xbuster=10;
        armadura armadura= new FalconArmor() ;

        public int Xbuster { get => xbuster; set => xbuster = value; }

        public int fuerza()
        {
            return Xbuster+armadura.BonificacionDeDanio();
        }

        public void entrenar(int minutos)
        {
            Xbuster+=minutos*2;
            armadura.Entrenamiento(minutos);
        }

        public void cambiarArmadura()
        {
            armadura = new ShadowArmor();
        }
    }
}