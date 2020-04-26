namespace E2
{
    public class Medico
    {  
        public string nombre;
        public string apellido;
        public string especialidad;
        public int cantidadDeTurnos=0;

        public Medico(string nombre, string apellido, string especialidad, int cantidadDeTurnos)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidadDeTurnos=cantidadDeTurnos;
        }

        public bool EstaDisponible()
        {
            return cantidadDeTurnos<50;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
    }
}