#pragma checksum "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cb7dfda6cf9ab519fb8b9e1c143ab8e5e56e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SistemaIntegralCYA.App.Frontend.Pages.router.Pages_router_DetallesBD), @"mvc.1.0.razor-page", @"/Pages/router/DetallesBD.cshtml")]
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
#line 1 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\_ViewImports.cshtml"
using SistemaIntegralCYA.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cb7dfda6cf9ab519fb8b9e1c143ab8e5e56e37", @"/Pages/router/DetallesBD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22de10ede68164cdc6b11413b553f5985b0282b0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_router_DetallesBD : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../router/BDClientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Informacón Detallada Cliente</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Identificación</th>
            <th scope=""col"">Nombres</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Numero Teléfono</th>
            <th scope=""col"">Correo Electronico</th>
            <th scope=""col"">Contraseña</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 21 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\felip\Desktop\Castro & Asociados\SistemaIntegralCYA.App\SistemaIntegralCYA.App.Frontend\Pages\router\DetallesBD.cshtml"
           Write(Model.clientes.ClaveUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cb7dfda6cf9ab519fb8b9e1c143ab8e5e56e376167", async() => {
                WriteLiteral("Base de Datos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaIntegralCYA.App.Frontend.Pages.router.DetallesBD> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaIntegralCYA.App.Frontend.Pages.router.DetallesBD> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SistemaIntegralCYA.App.Frontend.Pages.router.DetallesBD>)PageContext?.ViewData;
        public SistemaIntegralCYA.App.Frontend.Pages.router.DetallesBD Model => ViewData.Model;
    }
}
#pragma warning restore 1591
