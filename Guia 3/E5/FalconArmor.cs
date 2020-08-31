namespace E5
{
    public class FalconArmor : armadura 
    {
        int potencia = 25;
        int resistencia = 10;


        public int BonificacionDeDanio()
        {
            return (potencia+resistencia)/2;
        }
        public void Entrenamiento(int minutos)
        {
            resistencia-= minutos;
            if(resistencia<0)
            {
                resistencia=0;
            }
            potencia+=10;
        }
    }
}