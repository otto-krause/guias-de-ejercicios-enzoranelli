using System.Collections.Generic;
namespace E6
{
    public class Juego
    {
        string titulo="";
        string genero="";
        List<Clasificacion> clasificaciones = new List<Clasificacion>();

        public Juego(string titulo, string genero, List<Clasificacion> clasificaciones)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Clasificaciones = clasificaciones;
        }

        public string Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public List<Clasificacion> Clasificaciones { get => clasificaciones; set => clasificaciones = value; }

        public double promedio ()
        {
            double promedio=0.0;          
            foreach(var i in Clasificaciones)
            {
                promedio+=i.Estrellas;
            }
            return promedio/3;
        }
        public string TipoDeClasificacion()
        {
            string nota="";
            if (promedio()>=4 && promedio()<=5 )           
                nota="alta";           
            if (promedio()==3)
                nota="media";
            if(promedio()>=1 && promedio()<=2)
                nota="baja";
            return nota;
        }
    }
}