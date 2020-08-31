namespace E5
{
    public class ShadowArmor: armadura
    {
        int desgaste=1;

        Megaman xbuster = new Megaman();

        public void Entrenamiento(int minutos)
        {
            desgaste+=xbuster.Xbuster;
        }     

           public int BonificacionDeDanio()
           {
               return 80/desgaste;
           }


    }
}