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
    public class BDClientes : PageModel
    {
        private readonly ILogger<BDClientes> _logger;

        public BDClientes(ILogger<BDClientes> logger)
        {
            _logger = logger;
        }

        private readonly IRepositorioClientes repositorioClientes;

        public IEnumerable<Cliente> clientes { get; set; }

        public BDClientes(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }
    
        public void OnGet()
        {
            clientes = repositorioClientes.GetAll();
        }
    }
}