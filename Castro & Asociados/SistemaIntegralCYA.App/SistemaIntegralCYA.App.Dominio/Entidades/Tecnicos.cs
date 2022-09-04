using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIntegralCYA.App.Dominio.Entidades
{
    /// <summary>Class <c>Tecnicos</c>
    /// Modela los Tecnicos y la información del mismo
    /// </summary>     

    public class Tecnicos : Persona
    {
        public string TarjetaProfesional {get; set;}
        public Horario Horario {get; set;}
        public List<Servicio> Servicio {get; set;}
        public List<Historial> Historial {get; set;}        
    }
}    