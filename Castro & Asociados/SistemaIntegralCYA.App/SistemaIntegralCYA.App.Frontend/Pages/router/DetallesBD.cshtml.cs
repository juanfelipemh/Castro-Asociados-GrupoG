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
    public class DetallesBD : PageModel
    {
        /*private readonly ILogger<DetallesBD> _logger;

        public DetallesBD(ILogger<DetallesBD> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepositorioClientes repositorioClientes;

        public Cliente clientes { get; set; }

        public DetallesBD(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
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