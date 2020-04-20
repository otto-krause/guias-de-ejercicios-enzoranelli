namespace E7
{
    public class Celular
    {
        bool NFC=false;
        bool bluethoot=false;
        int memoria=0;
        int cantiApp=0;

        public Celular(bool NFC, bool bluethoot, int memoria, int cantiApp)
        {
            this.NFC= NFC;
            this.bluethoot=bluethoot;
            this.memoria=memoria;
            this.cantiApp=cantiApp;
        }
         Camaras Frontal = new Camaras (4,3);
         Camaras Trasera = new Camaras (8,5);
        public bool TeCargaLaSube()
        {
            return NFC;
        }
        public int MemoriaDisponible()
        {
            int pesoCamaras =0;
            pesoCamaras = Frontal.PesoTotalDeFotos()+Trasera.PesoTotalDeFotos();
            int pesoApps= 0;
            pesoApps = 70 * cantiApp;
            int totalPeso=0;
            totalPeso= pesoCamaras+pesoApps;
            return memoria-totalPeso;

        }
    }
}