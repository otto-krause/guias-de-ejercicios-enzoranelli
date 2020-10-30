namespace E4
{
    public class Programador : Empleado
    {
        private string Categoria;

        public Programador (int cajaBancaria,string Categoria) : base (cajaBancaria)
        {
            this.Categoria=Categoria;
        }

        public override void Depositar()
        {
            if(Categoria == "Junior")
                CajaBancaria+=30000;
            if(Categoria == "SemiSenior")
                CajaBancaria+=40000;
            if(Categoria == "Senior")
                CajaBancaria+=60000;
            
        } 
    }
}