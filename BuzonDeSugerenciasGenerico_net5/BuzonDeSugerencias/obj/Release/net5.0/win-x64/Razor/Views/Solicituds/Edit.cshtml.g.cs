#pragma checksum "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solicituds_Edit), @"mvc.1.0.view", @"/Views/Solicituds/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd777cf20d26604a1d30a0761f0f515b8cf1e3c", @"/Views/Solicituds/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fa4930d1ba5fb232e2b2971e200dd87554df88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Solicituds_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuzonDeSugerencias.Models.Solicitud>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main style=""min-height:500px;"">
    <div class=""section overflow-hidden"">
        <div class=""container z-2"">


            <h4 style=""margin-top: 0.5rem;"">Hoja de reclamo</h4>
            <hr style=""margin-top: 0.5rem; margin-bottom: 0.5rem;"" />
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c6155", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c6441", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c8202", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 14 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Nombres""><b>Nombres:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 18 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.ApellidoPaterno);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Apellidos""><b>Apellidos:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 20 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.ApellidoPaterno);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                                                 Write(Model.ApellidoMaterno);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Correo""><b>Correo Electr??nico:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 24 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Correo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Telefono""><b>Tel??fono / Celular:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 26 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Domicilio""><b>Domicilio:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 30 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Domicilio);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""TipoDoc""><b>Tipo de Documento:</b></label>
");
#nullable restore
#line 34 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                  
                                    var TipoDoc = Model.TipoDoc == 1 ? "DNI" : "Carnet de Extranjer??a";
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <label class=\"col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0\">");
#nullable restore
#line 37 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(TipoDoc);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Dni""><b>Documento:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label"">");
#nullable restore
#line 39 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                     Write(Model.Dni);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label style="" text-align:left"" class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""MayoriaDeEdad""><b>Mayor??a de edad:</b></label>
");
#nullable restore
#line 43 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                  
                                    var MayoriaDeEdad = Model.MayoriaDeEdad ? "SI" : "No";
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <label class=\"col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0\">");
#nullable restore
#line 46 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(MayoriaDeEdad);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""PadreNombre""><b>Nombre de Padre o Madre:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 48 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.PadreNombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right"" for=""BienContratado""><b>Bien contratado:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label"">");
#nullable restore
#line 52 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                     Write(Model.BienContratado);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right"" for=""NombreDelBienContratado""><b>Nombre del Bien Contratado:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label"">");
#nullable restore
#line 54 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                     Write(Model.NombreDelBienContratado);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""TipoDeInforme""><b>Escuela:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 58 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Escuela);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""TipoDeInforme""><b>Monto Reclamado:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 62 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.MontoReclamado);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""TipoDeInforme""><b>Tipo de informe:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 66 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.TipoDeInforme);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Titulo""><b>Pedido:</b></label>
                                <label class=""col-12 col-sm-12 col-md-3 col-lg-3 col-xl-3 col-form-label pb-0"">");
#nullable restore
#line 70 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right pb-0"" for=""Descripcion""><b>Detalle:</b></label>
                                <label class=""col-12 col-sm-12 col-md-9 col-lg-9 col-xl-9 col-form-label pb-0"">");
#nullable restore
#line 74 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                          Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                            </div>
                            <hr />
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right"" for=""Titulo"">Estado:</label>
                                <div class=""col-sm-12 col-sm-12 col-md-9 col-lg-9 col-xl-9"">
                                    <select id=""Estado"" name=""Estado"" runat=""server"" class=""form-control form-control-sm"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c23957", async() => {
                    WriteLiteral("Abierto");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("/>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c25224", async() => {
                    WriteLiteral("Cerrado");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("/>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd777cf20d26604a1d30a0761f0f515b8cf1e3c26491", async() => {
                    WriteLiteral("Spam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"/>
                                    </select>
                                    Si el estado es ""Cerrado"" se enviara un correo de respuesta.
                                </div>

                            </div>
                            <div class=""form-group row mb-0"">
                                <label class=""col-12 col-sm-12 col-md-3 col-xl-3 col-lg-3 col-form-label text-right"" for=""Respuesta"">Respuesta:</label>
                                <div class=""col-sm-12 col-sm-12 col-md-9 col-lg-9 col-xl-9"">
                                    <textarea class=""form-control form-control-sm"" id=""Respuesta"" name=""Respuesta"" required>");
#nullable restore
#line 92 "C:\Users\Administrador\Documents\GitHub\libroreclamaciones-agilex\BuzonDeSugerenciasGenerico_net5\BuzonDeSugerencias\Views\Solicituds\Edit.cshtml"
                                                                                                                       Write(Model.Respuesta);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""Respuesta"" data-valmsg-replace=""true""></span>
                                </div>
                            </div>
                            <div class=""form-group text-right mt-1"">
                                <input type=""submit"" value=""Guardar cambios"" class=""btn btn-primary"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div>\r\n                            <a href=\"/Solicituds\">Regresar</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuzonDeSugerencias.Models.Solicitud> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
