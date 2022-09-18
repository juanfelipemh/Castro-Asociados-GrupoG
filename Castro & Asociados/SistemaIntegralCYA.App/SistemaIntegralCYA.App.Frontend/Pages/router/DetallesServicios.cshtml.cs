using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaIntegralCYA.App.Dominio.Entidades;
using SistemaIntegralCYA.App.Persistencia.AppRepositorios;

namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    public class DetallesServicios : PageModel
    {
        private readonly IRepositorioServicio repositorioServicios;

        public Servicio servicios { get; set; }

        public DetallesServicios()
        {
            this.repositorioServicios = new RepositorioServicio(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }


        public IActionResult OnGet(int servicioId)
        {
            servicios = repositorioServicios.GetServicioPorId(servicioId);
            if (servicios == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}