#pragma checksum "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Finance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4034125c0c3901a4617ad3a9bd8c43b1f10c5d40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_Index), @"mvc.1.0.view", @"/Views/Finance/Index.cshtml")]
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
#line 1 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\_ViewImports.cshtml"
using Archi_Back;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\_ViewImports.cshtml"
using Archi_Back.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4034125c0c3901a4617ad3a9bd8c43b1f10c5d40", @"/Views/Finance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e8e52b25aaa2e63f5a6c13e6d7402d3122d755", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Finance\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Finance\Index.cshtml"
 foreach(Archi_Data.Finance finance in ViewBag.fin)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>");
#nullable restore
#line 9 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Finance\Index.cshtml"
  Write(finance.Actif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 10 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Finance\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
