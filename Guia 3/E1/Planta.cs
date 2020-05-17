namespace E1
{
    public class Planta
    {
        private int barrasDeUranio;
        MrBurns burns;
        private Empleado empleado;

        public int BarrasDeUranio { get => barrasDeUranio; set => barrasDeUranio = value; }

        public Planta(int barrasDeUranio, Empleado empleado, MrBurns burns)
        {
            this.BarrasDeUranio = barrasDeUranio;
            this.burns = burns;
            this.empleado = empleado;
        }

        public bool estaEnPeligro(){
            return (BarrasDeUranio > 10000 && empleado.estaDistraido())
                    || !burns.esMillonario();
        }

        public void CambiarEmpleado(Empleado nuevoEmpleado){
            empleado = nuevoEmpleado;
        }
    }
}