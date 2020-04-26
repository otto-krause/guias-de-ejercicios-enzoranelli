namespace E3
{
    public class Figuritas
    {
        public string nombreJugador= null;
        public string posicion = null;
        public string pais = null;
        public int numDeFigu = 0;

        public Figuritas (string nombreJugador, string posicion, string pais, int numDeFigu)
        {
            this.nombreJugador= nombreJugador;
            this.posicion = posicion;
            this.pais = pais;
            this.numDeFigu = numDeFigu;
        }
    }
}