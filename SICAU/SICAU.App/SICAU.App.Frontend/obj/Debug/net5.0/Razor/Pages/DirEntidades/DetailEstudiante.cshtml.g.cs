#pragma checksum "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a2f840d2508e501d042a71d1eed844c80860a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SICAU.App.Frontend.Pages.DirEntidades.Pages_DirEntidades_DetailEstudiante), @"mvc.1.0.razor-page", @"/Pages/DirEntidades/DetailEstudiante.cshtml")]
namespace SICAU.App.Frontend.Pages.DirEntidades
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
#line 1 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\_ViewImports.cshtml"
using SICAU.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a2f840d2508e501d042a71d1eed844c80860a3", @"/Pages/DirEntidades/DetailEstudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696e780f3b9bb690caa9c737c7e570ba1229e39a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DirEntidades_DetailEstudiante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/DirEntidades/ListEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<script src=\'https://kit.fontawesome.com/a076d05399.js\'></script>\r\n\r\n<h1> Detalle Estudiante ID: ");
#nullable restore
#line 7 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
                       Write(Model.estudiante.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h4></h4>\r\n\r\n<tr>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a2f840d2508e501d042a71d1eed844c80860a34288", async() => {
                WriteLiteral("\r\n        <i class=\"fas fa-arrow-circle-left\"></i> \r\n            Regresar\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n\r\n<h4></h4>\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <tr>\r\n        <td class=\"table-dark\">ID Estudiante</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Nombres</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Apellido </td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Número de Identificacion</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Fecha de Nacimiento</td>\r\n        <td>");
#nullable restore
#line 41 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.fechaNacimiento.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Estado Covid Actual</td>\r\n        <td>");
#nullable restore
#line 45 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.estadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Semestre</td>\r\n        <td>");
#nullable restore
#line 49 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td class=\"table-dark\">Programa</td>\r\n        <td>");
#nullable restore
#line 53 "C:\Users\mazul\Desktop\Desarrollo de Software MinTic\C#\Proyecto_SICAU\SICAU\SICAU.App\SICAU.App.Frontend\Pages\DirEntidades\DetailEstudiante.cshtml"
       Write(Model.estudiante.programa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SICAU.App.Frontend.Pages.DetailEstudianteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SICAU.App.Frontend.Pages.DetailEstudianteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SICAU.App.Frontend.Pages.DetailEstudianteModel>)PageContext?.ViewData;
        public SICAU.App.Frontend.Pages.DetailEstudianteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
