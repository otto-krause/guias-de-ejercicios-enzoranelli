using System.Collections.Generic;
using System.Linq;
namespace E4
{
    public class Clinica
    {
        private List<Medico> medicos;

        public Clinica(List<Medico> medicos)
        {
            this.medicos = medicos;
        }

        public Medico EstaDisponible(string especialidad)
        {
            List<Medico> disponibles = medicos.Where(medico => medico.Turnos<50 && medico.Especialidad == especialidad).ToList();
            foreach(var i in disponibles)
            {
                i.turno();
                return i;
            }
            return null;
        }   
    }
}