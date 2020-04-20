namespace E7
{
    public class Camaras
    {
        int megapixeles=0;
        int cantDeFotos=0;

        public Camaras(int megapixeles, int cantDeFotos)
        {
            this.megapixeles= megapixeles;
            this.cantDeFotos = cantDeFotos;
        }
        public int pesoPorFoto()
        {
            int pixel=0;
            int pesoEnMb=0;
            pixel=megapixeles*1000000;
            pesoEnMb=pixel*3/1000000;
            return pesoEnMb;
        }
        public int PesoTotalDeFotos()
        {
            int pesoFoto=0;
            pesoFoto=this.pesoPorFoto();
            int pesoEnMb=0;
            pesoEnMb=cantDeFotos*pesoFoto;
            return pesoEnMb;
        }
    }
}