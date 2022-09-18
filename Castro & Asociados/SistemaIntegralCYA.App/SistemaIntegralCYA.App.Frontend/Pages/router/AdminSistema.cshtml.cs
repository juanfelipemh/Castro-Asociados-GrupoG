using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    public class AdminSistema : PageModel
    {
        private readonly ILogger<AdminSistema> _logger;

        public AdminSistema(ILogger<AdminSistema> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}