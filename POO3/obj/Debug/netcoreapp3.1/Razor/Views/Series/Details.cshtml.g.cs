#pragma checksum "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9b5cf31039cc4f6a46b496f58997a20a0550cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Details), @"mvc.1.0.view", @"/Views/Series/Details.cshtml")]
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
#line 1 "C:\Users\leleo\source\repos\POO3\POO3\Views\_ViewImports.cshtml"
using POO3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leleo\source\repos\POO3\POO3\Views\_ViewImports.cshtml"
using POO3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9b5cf31039cc4f6a46b496f58997a20a0550cbd", @"/Views/Series/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb25037542b94ee22d6f966066f1f0bced1b7b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POO3.Models.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Serie</h4>\r\n    <h3>\r\n        ");
#nullable restore
#line 12 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
   Write(Html.DisplayFor(model => Model.Serie.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <hr />\r\n    <table class=\" table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("asp-", " asp-=\"", 317, "\"", 382, 1);
#nullable restore
#line 19 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
WriteAttributeValue("", 324, Html.DisplayNameFor(model => model.Episodio.Nomeepisodio), 324, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nome Episódio</a>\r\n                </th>\r\n\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("asp-", " asp-=\"", 472, "\"", 539, 1);
#nullable restore
#line 23 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
WriteAttributeValue("", 479, Html.DisplayNameFor(model => model.Episodio.Numeroepisodio), 479, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Número Episódio</a>\r\n                </th>\r\n\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("asp-", " asp-=\"", 631, "\"", 693, 1);
#nullable restore
#line 27 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
WriteAttributeValue("", 638, Html.DisplayNameFor(model => model.Episodio.Temporada), 638, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Temporada</a>\r\n                </th>\r\n\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("asp-", " asp-=\"", 779, "\"", 841, 1);
#nullable restore
#line 31 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
WriteAttributeValue("", 786, Html.DisplayNameFor(model => model.Episodio.Avaliacao), 786, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Avaliação</a>\r\n                </th>\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
             foreach (int item in Model.Episodio.Nomeepisodio)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
               Write(Html.DisplayFor(model => model.Episodio.Nomeepisodio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
               Write(Html.DisplayFor(model => model.Episodio.Numeroepisodio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
               Write(Html.DisplayFor(model => model.Episodio.Temporada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
               Write(Html.DisplayFor(model => model.Episodio.Avaliacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n</div>\r\n\r\n\r\n\r\n                \r\n\r\n\r\n\r\n\r\n<div>\r\n \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9b5cf31039cc4f6a46b496f58997a20a0550cbd8196", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\leleo\source\repos\POO3\POO3\Views\Series\Details.cshtml"
                           WriteLiteral(Model.Episodio.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9b5cf31039cc4f6a46b496f58997a20a0550cbd10333", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POO3.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591