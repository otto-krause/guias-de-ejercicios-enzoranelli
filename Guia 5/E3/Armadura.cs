namespace E3
{
    public class Armadura
    {
        private string Nombre;
        private string Material;

        public Armadura(string nombre, string material)
        {
            Nombre = nombre;
            Material = material;
        }
        public string Nombre1 { get => Nombre; }
        public string Material1 { get => Material; } 
    }
}