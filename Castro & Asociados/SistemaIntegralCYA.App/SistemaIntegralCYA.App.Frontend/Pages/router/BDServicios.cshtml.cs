using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaIntegralCYA.App.Dominio.Entidades;
using SistemaIntegralCYA.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    public class BDServicios : PageModel
    {
        private readonly IRepositorioServicio repositorioServicios;

        public IEnumerable<Servicio> servicios {get; set;}

        public BDServicios()
        {
            this.repositorioServicios = new RepositorioServicio(new SistemaIntegralCYA.App.Persistencia.AppContext());
        } 

        public void OnGet(string filtroBusqueda)
        {
            servicios = repositorioServicios.GetAll();
        }
    }
}