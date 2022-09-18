using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SistemaIntegralCYA.App.Dominio.Entidades;
using SistemaIntegralCYA.App.Persistencia.AppRepositorios;
namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    public class UpdateTecnico : PageModel
    {
        
        private readonly IRepositorioTecnico repositorioTecnicos;

        [BindProperty]
        public Tecnicos tecnicos {get; set;}

        public UpdateTecnico()
        {
            this.repositorioTecnicos = new RepositorioTecnico(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? tecnicoId)
        {
            if(tecnicoId.HasValue)
            {
                tecnicos = repositorioTecnicos.GetTecnicoPorId(tecnicoId.Value);
            }
            else
            {
                tecnicos = new Tecnicos();
            }
            if(tecnicos == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            if(tecnicos.Id >= 0)
            {
                tecnicos = repositorioTecnicos.UpdateTecnico(tecnicos);
            }
            else
            {
                repositorioTecnicos.AddTecnico(tecnicos);
            }
            return Page();
        }
    }
}