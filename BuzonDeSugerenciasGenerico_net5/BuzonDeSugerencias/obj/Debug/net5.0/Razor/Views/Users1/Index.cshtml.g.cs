#pragma checksum "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1567097d430b91474a64fe003e0594721f66d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users1_Index), @"mvc.1.0.view", @"/Views/Users1/Index.cshtml")]
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
#line 1 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\_ViewImports.cshtml"
using BuzonDeSugerencias;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\_ViewImports.cshtml"
using BuzonDeSugerencias.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1567097d430b91474a64fe003e0594721f66d6", @"/Views/Users1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fa4930d1ba5fb232e2b2971e200dd87554df88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuzonDeSugerencias.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1567097d430b91474a64fe003e0594721f66d64890", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UniqueId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeDoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberDoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CellPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Modified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Enabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UniqueId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeDoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberDoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CellPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Modified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Enabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1567097d430b91474a64fe003e0594721f66d616412", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1567097d430b91474a64fe003e0594721f66d618642", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1567097d430b91474a64fe003e0594721f66d620878", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 105 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Users1\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuzonDeSugerencias.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
