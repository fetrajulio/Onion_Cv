#pragma checksum "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95711e4a3323272a5ea4961235a464fe47d6ae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95711e4a3323272a5ea4961235a464fe47d6ae5", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e8e52b25aaa2e63f5a6c13e6d7402d3122d755", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onkeyup", new global::Microsoft.AspNetCore.Html.HtmlString("sum()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("calc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br /><br />
<div class=""row"">
    
    <div class=""col-7"">
        
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">Nom Produit</th>
                        <th scope=""col"">Prix Unitaire</th>
                        
                        <th scope=""col"">Disponibilite</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 21 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                     foreach (Archi_Data.Produit p in ViewBag.produits)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                       Write(p.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                           Write(p.PrixUnitaire);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ar</td>\r\n                            <td>\r\n");
#nullable restore
#line 29 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                 if (p.QteStock != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success\">Disponible</span>\r\n");
#nullable restore
#line 32 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger\">epuise</span>\r\n");
#nullable restore
#line 36 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1354, "\"", 1466, 7);
            WriteAttributeValue("", 1364, "location.href", 1364, 13, true);
            WriteAttributeValue(" ", 1377, "=", 1378, 2, true);
            WriteAttributeValue(" ", 1379, "\'https://localhost:5001/Client/acheter?user=", 1380, 45, true);
#nullable restore
#line 39 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
WriteAttributeValue("", 1424, ViewBag.Client.Utilisateur, 1424, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1451, "&idProd=", 1451, 8, true);
#nullable restore
#line 39 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
WriteAttributeValue("", 1459, p.Id, 1459, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1464, "\';", 1464, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Acheter</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n    </div>\r\n    \r\n    <div class=\"col-5\">\r\n        <br /><br /><br />\r\n        <div class=\"card border-primary mb-3\">\r\n            <div class=\"card-header\">Validation d\'achat de ");
#nullable restore
#line 52 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                                      Write(ViewBag.Client.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n\r\n                <h5>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
               Write(ViewBag.panier.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95711e4a3323272a5ea4961235a464fe47d6ae59323", async() => {
                WriteLiteral("\r\n\r\n                   \r\n                    <select name=\"nbr\" class=\"form-select\" id=\"nbr\" onkeyup=\"sum()\">\r\n");
#nullable restore
#line 62 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                         for (int a = 0; a < ViewBag.panier.QteStock; a++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95711e4a3323272a5ea4961235a464fe47d6ae510027", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 64 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                                           Write(a);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" sur ");
#nullable restore
#line 64 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                                                  Write(ViewBag.panier.QteStock);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                                               WriteLiteral(a);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n\r\n                    <button type=\"submit\" value=\"calculate\" class=\"btn btn-outline-primary\">Valider l\'achats</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2037, "https://localhost:5001/Client/valAchat?idprod=", 2037, 46, true);
#nullable restore
#line 58 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
AddHtmlAttributeValue("", 2083, ViewBag.panier.Id, 2083, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2101, "&idclient=", 2101, 10, true);
#nullable restore
#line 58 "C:\Users\Dialy\source\repos\Archi_Back\Archi_Back\Views\Client\Index.cshtml"
AddHtmlAttributeValue("", 2111, ViewBag.Client.Id, 2111, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2129, "+", 2129, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              \r\n\r\n            </div>\r\n    </div>\r\n    \r\n</div>\r\n\r\n");
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
