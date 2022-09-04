using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIntegralCYA.App.Dominio.Entidades
{
    /// <summary>Class <c>Administrador</c>
    /// Modela el Administrador como superusuario
    /// </summary> 

    public class Administrador : Persona
    {
        public List<Historial> Historial {get; set;}
    }
}