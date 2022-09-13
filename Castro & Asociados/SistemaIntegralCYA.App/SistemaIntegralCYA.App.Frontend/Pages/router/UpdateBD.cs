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
    public class UpdateBD : PageModel
    {
        /*private readonly ILogger<ModificarBD> _logger;

        public ModificarBD(ILogger<ModificarBD> logger)
        {
            _logger = logger;
        }*/

        private readonly IRepositorioClientes repositorioClientes;

        [BindProperty] // Esta propiedad se uso para crear vinculo entre la página Razor (Formulario) y el Modelo (entidad)
        public Cliente clientes { get; set; }

        public UpdateBD(IRepositorioClientes repositorioClientes)
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

        public IActionResult OnPost() // Con esto, al momento de darle modificar a los datos, publica el dato corregido en la base de datos. Por eso la tabla se uso method="post"
        {
            clientes = repositorioClientes.UpdateUsuario(clientes);
            return Page();
        }
    }
}