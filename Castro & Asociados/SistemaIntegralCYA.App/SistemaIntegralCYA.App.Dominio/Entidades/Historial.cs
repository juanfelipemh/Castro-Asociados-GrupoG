using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIntegralCYA.App.Dominio.Entidades
{
    /// <summary>Class <c>Historial</c>
    /// Modela el Historial de servicios de la compañia
    /// </summary> 

    public class Historial
    {
        // Identificador único del historial
        public int Id {get; set;}
        public Horario Horario {get; set;}
        public DateTime FechaServicio {get; set;}
        public string Servicio {get; set;}
        public string DescripcionServicio {get; set;}
        public float Valor {get; set;}
    }
}