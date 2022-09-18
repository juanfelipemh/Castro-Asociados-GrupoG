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
    public class DetallesBD : PageModel
    {        
        private readonly IRepositorioClientes repositorioClientes;

        public Cliente clientes { get; set; }

        public DetallesBD()
        {
            this.repositorioClientes = new RepositorioClientesMemoria(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int clienteId)
        {
            clientes = repositorioClientes.GetClientePorId(clienteId);
            if (clientes == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}