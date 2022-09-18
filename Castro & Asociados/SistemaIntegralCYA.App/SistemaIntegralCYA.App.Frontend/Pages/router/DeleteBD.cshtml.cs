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
    public class DeleteBD : PageModel
    {
        private readonly IRepositorioClientes repositorioClientes;

        [BindProperty] // Esta propiedad se uso para crear vinculo entre la página Razor (Formulario) y el Modelo (entidad)
        public Cliente clientes { get; set; }

        public DeleteBD()
        {
            this.repositorioClientes = new RepositorioClientesMemoria(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                clientes = repositorioClientes.GetClientePorId(clienteId.Value);
            }

            if (clientes == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost() // Con esto, al momento de darle modificar a los datos, publica el dato corregido en la base de datos. Por eso la tabla se uso method="post"
        {
            if (clientes.Id > 0)
            {
                repositorioClientes.DeleteUsuario(clientes.Id);
            }
            else
            {
                repositorioClientes.AddUsuario(clientes);
            }
            return Page();
        }
    }
}