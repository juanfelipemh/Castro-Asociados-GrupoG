using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    public class IngresoAdmin : PageModel
    {
        private readonly ILogger<IngresoAdmin> _logger;

        public IngresoAdmin(ILogger<IngresoAdmin> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}