namespace E4
{
    public class Administrador : Empleado
    {
        public Administrador(int cajaBancaria) : base (cajaBancaria)
        {
        }

        public override void Depositar()
        {
            CajaBancaria+=35000;
        }        
    }
}