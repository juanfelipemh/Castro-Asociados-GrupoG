using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIntegralCYA.App.Dominio.Entidades
{
    /// <summary>Class <c>Cliente</c>
    /// Modela el Cliente y la información del mismo
    /// </summary> 

    public class Cliente : Persona
    {
        public Horario Horario { get; set; }
        public Tecnicos Tecnico { get; set; }
        public string Descripcion { get; set; }
        public List<Historial> Historial { get; set; }
    }
}