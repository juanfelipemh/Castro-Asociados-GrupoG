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
    public class BDTecnicos : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnicos;

        public IEnumerable<Tecnicos> tecnicos {get; set;}

        public BDTecnicos()
        {
            this.repositorioTecnicos = new RepositorioTecnico(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            tecnicos = repositorioTecnicos.GetAll();
        }
    }
}