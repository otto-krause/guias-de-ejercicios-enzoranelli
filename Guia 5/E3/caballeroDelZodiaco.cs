namespace E3
{
    public class caballeroDelZodiaco
    {
        private string Nombre;
        private string Dios;
        private string signoZodiacal;
        private Armadura armadura;

        public caballeroDelZodiaco(string nombre, string dios, string signoZodiacal, Armadura armadura)
        {
            Nombre = nombre;
            Dios = dios;
            this.signoZodiacal = signoZodiacal;
            this.armadura = armadura;
        }

        public string Nombre1 { get => Nombre;}
        public string Dios1 { get => Dios;  }
        public string SignoZodiacal { get => signoZodiacal;  }
        public Armadura Armadura { get => armadura;  }
        
    }
}