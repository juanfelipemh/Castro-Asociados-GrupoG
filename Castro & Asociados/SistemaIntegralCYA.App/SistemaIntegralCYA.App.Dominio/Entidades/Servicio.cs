using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaIntegralCYA.App.Dominio.Entidades
{
    /// <summary>Class <c>Servicio</c>
    /// Modela el Servicio que ofrece la compañia
    /// </summary> 

    public class Servicio 
    {   
        // Identificador único del servicio
        public int Id {get; set;}
        public string Descripcion {get; set;}
        public float Costo {get; set;}
    }
}