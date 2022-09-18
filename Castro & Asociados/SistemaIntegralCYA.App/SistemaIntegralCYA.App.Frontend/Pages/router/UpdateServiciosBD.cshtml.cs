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
    public class UpdateServiciosBD : PageModel
    {
        private readonly IRepositorioServicio repositorioServicios;

        [BindProperty]
        public Servicio servicios {get; set;}

        public UpdateServiciosBD()
        {
            this.repositorioServicios = new RepositorioServicio(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? servicioId)
        {
            if(servicioId.HasValue)
            {
                servicios = repositorioServicios.GetServicioPorId(servicioId.Value);
            }
            else
            {
                servicios = new Servicio();
            }
            if(servicios == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            if(servicios.Id >= 0)
            {
                servicios = repositorioServicios.UpdateServicio(servicios);
            }
            else
            {
                repositorioServicios.AddServicio(servicios);
            }
            return Page();
        }
    }
}