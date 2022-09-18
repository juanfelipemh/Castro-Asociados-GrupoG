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
    public class BDClientes : PageModel
    {        

        private readonly IRepositorioClientes repositorioClientes;

        public IEnumerable<Cliente> clientes { get; set; }

        public BDClientes()
        {
            this.repositorioClientes = new RepositorioClientesMemoria(new SistemaIntegralCYA.App.Persistencia.AppContext());
        }

        public void OnGet(string filtroBusqueda)
        {
            clientes = repositorioClientes.GetAll();
        }

    }
}