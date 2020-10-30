namespace E4
{
    public abstract class Empleado
    {
        private int cajaBancaria;

        public int CajaBancaria { get => cajaBancaria; set => cajaBancaria = value; }

        protected Empleado(int cajaBancaria)
        {
            this.CajaBancaria=cajaBancaria;
        }

        public void Extraer(int monto)
        {
            CajaBancaria-=monto;
        }
        public abstract void Depositar();
    }
}