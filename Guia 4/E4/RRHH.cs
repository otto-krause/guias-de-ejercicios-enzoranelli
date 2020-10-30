namespace E4
{
    public class RRHH : Empleado
    {
        private int PersonasRef;

        public RRHH (int cajaBancaria, int PersonasRef): base(cajaBancaria)
        {
            this.PersonasRef=PersonasRef;
        }

        public override void Depositar()
        {
            CajaBancaria+=5000+PersonasRef*5000;
        }
    }
}