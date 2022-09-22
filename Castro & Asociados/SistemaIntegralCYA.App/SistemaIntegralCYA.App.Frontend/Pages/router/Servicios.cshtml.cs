using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaIntegralCYA.App.Dominio.Entidades;
using SistemaIntegralCYA.App.Persistencia.AppRepositorios;
namespace SistemaIntegralCYA.App.Pages
{
    public class ServiciosModel : PageModel
    {
        private readonly IRepositorioHIstorial repositorioHIstoriales;
        private readonly IRepositorioTecnico repositorioTecnicos;
                
        [BindProperty]
        public Historial historial {get; set;}

        [BindProperty]
        public IEnumerable<Tecnicos> tecnicos {get; set;}

        public ServiciosModel()
        {
            this.repositorioHIstoriales = new RepositorioHistorial(new SistemaIntegralCYA.App.Persistencia.AppContext());
            this.repositorioTecnicos = new RepositorioTecnico(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? historialId)
        {
            if(historialId.HasValue)
            {
                historial = repositorioHIstoriales.GetHistorialPorId(historialId.Value);
            }
            else
            {
                historial = new Historial();
            }
            if(historial == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }   

        public IActionResult OnPost()
        {
            if(historial.Id > 0)
            {
                historial = repositorioHIstoriales.UpdateHistorial(historial);
            }
            else
            {
                repositorioHIstoriales.AddHistorial(historial);
            }
            return Page();
        } 

            
        
    }
}


