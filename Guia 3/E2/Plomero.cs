namespace E2
{
    public class Plomero:contratista
    {
        int hora=0;

        public Plomero(int hora)
        {
            this.hora = hora;
        }      
        public void trabajar(int horas)
        {
            hora=horas;
        }
        public int cobrar()
        {
            return 80*hora;
        }
    }
}