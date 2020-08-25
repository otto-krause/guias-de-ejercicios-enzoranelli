namespace E2
{
    public class pintores : contratista
    {    
        int hora=0;

        public pintores(int hora)
        {
            this.hora = hora;
        }

        public void trabajar(int horas)
        {  
            hora=horas;
        }
        public int cobrar()
        {
            return (3*50)*hora;
        }
    }
}