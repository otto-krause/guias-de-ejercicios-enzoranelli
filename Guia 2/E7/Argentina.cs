using System.Collections.Generic;
namespace E7
{
    public class Argentina
    {
        List<Alfajor> alfajores = new List<Alfajor>();
        public List<Alfajor> Alfajores { get => alfajores; set => alfajores = value; }
        public Argentina(List<Alfajor> alfajores)
        {
            this.Alfajores = alfajores;
        }
        public void BajarPrecioDePetroleo()
        {
            foreach ( var i in Alfajores)
            {
                i.Precio+=80;
            }
        }
        public void MilllaiHablaPorTv()
        {
             foreach ( var i in Alfajores)
            {
                i.Precio=i.Precio*2;
            }
        }
        public void CoronaVairas()
        {
            foreach (var i in Alfajores )
            {
                if (i.NombreDeEmpresa != "Waymayen")
                    i.Precio=+1000;
            }
        }
        public string Inflacion()
        {
            double suma=0;
            foreach(var i in Alfajores)
            {
                suma+=i.Precio;
            }
            string infla="";
            if (suma<500)
                infla="normal";
            if(suma>500 && suma<1000)
                infla="super";
            if(suma>1000)
                infla="hyper";
            return infla;        
        }
        public bool Default()
        {
            return Inflacion()=="hyper";
        }
    }
}