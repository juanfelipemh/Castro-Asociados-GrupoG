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
    public class IngresoUsuarioModel : PageModel
    {
        private readonly IRepositorioClientes repositorioClientes;
        public IEnumerable<Cliente> clientes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FiltroBusqueda { get; set; }

        public IngresoUsuarioModel()
        {
            this.repositorioClientes = new RepositorioClientesMemoria(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda = filtroBusqueda;
            clientes = repositorioClientes.GetClientePorFiltro(filtroBusqueda);
        }
    }
}