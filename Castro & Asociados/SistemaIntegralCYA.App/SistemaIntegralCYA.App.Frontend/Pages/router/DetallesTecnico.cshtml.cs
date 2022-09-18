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
    public class DetallesTecnico : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnicos;

        public Tecnicos tecnicos { get; set; }

        public DetallesTecnico()
        {
            this.repositorioTecnicos = new RepositorioTecnico(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }


        public IActionResult OnGet(int tecnicoId)
        {
            tecnicos = repositorioTecnicos.GetTecnicoPorId(tecnicoId);
            if (tecnicos == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}