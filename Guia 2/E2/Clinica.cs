using System.Collections.Generic;
namespace E2
{
    public class Clinica
    {
        List<Medico> medicos = new List<Medico>(); 
        public Clinica()
        {
            medicos.Add(new Medico("Enzo","Ranelli","Pediatra",41));
            medicos.Add(new Medico("Juan","Perez","Clinico",51));
            medicos.Add(new Medico("Carlos","Gimenez","Pediatra",55));
            medicos.Add(new Medico("Saul","Fernandez","Clinico",38));
            medicos.Add(new Medico("Jorge","Garcia","Dentista",56));
            medicos.Add(new Medico("Pablo","Gonzalez","Pediatra",32));
           
        }

        public string Turnos(string especial)
        {
            string nomb = null;
            string ape = null;
            foreach (var i in medicos)
            {
                if(i.especialidad==especial)
                {
                    if(i.EstaDisponible())
                    {   
                       nomb=i.getNombre();
                       ape=i.getApellido();
                    }
                }
                
            }
            return nomb+" "+ape;
            
        }

    }
}