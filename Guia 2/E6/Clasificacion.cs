namespace E6
{
    public class Clasificacion
    {
        int estrellas=0;
        string comentario="";

        public Clasificacion(int estrellas, string comentario)
        {
            this.Estrellas = estrellas;
            this.comentario = comentario;
        }

        public int Estrellas { get => estrellas; set => estrellas = value; }

       
    }
}