namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;
        
        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre = nombre;
            this.vacunas = vacunas;
            this.energia = energia;

        }

        public bool estaSaludable(){
            return vacunas && energia > 30;
        }
        public void comer(){
            energia=energia+50;
        }
        public string Nombre(){
            return nombre;
        }
        public bool estaVacunado(){
            return vacunas;
        }
        public void Jugar (int minutos){
            energia=energia-2*minutos;
        }
        public int energy(){
            return energia;
        }

    }
}