#pragma checksum "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d45b8349f5000d2b5e80a0f53638835feb7e217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Index), @"mvc.1.0.view", @"/Views/Departamentos/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\_ViewImports.cshtml"
using MvcCoreAWSPostgres;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d45b8349f5000d2b5e80a0f53638835feb7e217", @"/Views/Departamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eccdebb92a931fc7a3b7559d3e803a2ebb4b95fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcCoreAWSPostgres.Models.Departamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdDepartamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdDepartamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.IdDepartamento }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\enriq\Desktop\AWS\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Departamentos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcCoreAWSPostgres.Models.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
