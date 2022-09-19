using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaIntegralCYA.App.Dominio.Entidades;
using SistemaIntegralCYA.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;
namespace SistemaIntegralCYA.App.Pages
{
    public class HistorialModelDetalle : PageModel
    {
        private readonly IRepositorioHIstorial repositorioHIstoriales;

        public IEnumerable<Historial> historial {get; set;}

        public HistorialModelDetalle()
        {
            this.repositorioHIstoriales = new RepositorioHistorial(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            historial = repositorioHIstoriales.GetAll();
        }
    }
}
