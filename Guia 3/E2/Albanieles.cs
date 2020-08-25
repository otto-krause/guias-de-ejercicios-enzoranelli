namespace E2
{
    public class Albanieles:contratista
    {
        bool titulo;
        int edad;

        int hora;

        public Albanieles(bool titulo, int edad, int hora)
        {
            this.titulo = titulo;
            this.edad = edad;
            this.hora = hora;
        }

        public void trabajar (int horas)
        {
            hora=horas;
        }
        public int cobrar ()
        {
            int acu=0;
            if(edad>20 && edad<30)
                acu=50;
            if(edad>30 && edad<50)
                acu=90;
            if(edad>50)       
                acu=120;
            if(titulo)
                acu+=50;
            return acu*hora;
        
        }


    }
}