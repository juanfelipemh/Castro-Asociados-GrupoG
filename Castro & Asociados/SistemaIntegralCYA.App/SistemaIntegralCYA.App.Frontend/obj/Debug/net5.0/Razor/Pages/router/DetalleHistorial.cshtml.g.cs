#pragma checksum "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetalleHistorial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8394e7f50cc373592607a1865e4c44fe86f3e58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SistemaIntegralCYA.App.Frontend.Pages.router.Pages_router_DetalleHistorial), @"mvc.1.0.razor-page", @"/Pages/router/DetalleHistorial.cshtml")]
namespace SistemaIntegralCYA.App.Frontend.Pages.router
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\_ViewImports.cshtml"
using SistemaIntegralCYA.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8394e7f50cc373592607a1865e4c44fe86f3e58", @"/Pages/router/DetalleHistorial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22de10ede68164cdc6b11413b553f5985b0282b0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_router_DetalleHistorial : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Historial</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8394e7f50cc373592607a1865e4c44fe86f3e583242", async() => {
                WriteLiteral(@"
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Horario Servicio</th>
                <th scope=""col"">Fecha Servicio</th>
                <th scope=""col"">Nombre Técnico</th>
                <th scope=""col"">Servicio</th>
                <th scope=""col"">Descripción Servicio</th>
                <th scope=""col"">Valor</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetalleHistorial.cshtml"
             foreach (var historial in Model.historial)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>10 am</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetalleHistorial.cshtml"
                   Write(historial.FechaServicio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Martin Elias Jimenez Posada</td>\r\n                    <td>Mantenimiento</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetalleHistorial.cshtml"
                   Write(historial.DescripcionServicio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>$100.000</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\felip\OneDrive\Castro-Asociados-GrupoG\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetalleHistorial.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </tbody>\r\n        <a class=\"submitBtn nav-link\" href=\"../router/Aplicativo\">Menu Principal<a>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaIntegralCYA.App.Pages.HistorialModelDetalle> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaIntegralCYA.App.Pages.HistorialModelDetalle> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaIntegralCYA.App.Pages.HistorialModelDetalle>)PageContext?.ViewData;
        public SistemaIntegralCYA.App.Pages.HistorialModelDetalle Model => ViewData.Model;
    }
}
#pragma warning restore 1591
