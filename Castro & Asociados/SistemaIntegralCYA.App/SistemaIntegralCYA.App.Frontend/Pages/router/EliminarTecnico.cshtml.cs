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
    public class EliminarTecnico : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnicos;

        [BindProperty]
        public Tecnicos tecnicos {get; set;}

        public EliminarTecnico()
        {
            this.repositorioTecnicos = new RepositorioTecnico(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? tecnicoId)
        {
            if(tecnicoId.HasValue)
            {
                tecnicos = repositorioTecnicos.GetTecnicoPorId(tecnicoId.Value);
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
            if(tecnicos.Id > 0)
            {
                repositorioTecnicos.DeleteTecnico(tecnicos.Id);
            }
            else
            {
                repositorioTecnicos.AddTecnico(tecnicos);
            }
            return Page();
        }
    }
}