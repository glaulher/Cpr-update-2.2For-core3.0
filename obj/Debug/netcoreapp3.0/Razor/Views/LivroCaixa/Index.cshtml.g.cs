#pragma checksum "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca710a54ddc06b280ef817160dd6c6775c0e03a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LivroCaixa_Index), @"mvc.1.0.view", @"/Views/LivroCaixa/Index.cshtml")]
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
#line 1 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/_ViewImports.cshtml"
using Cpr.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/_ViewImports.cshtml"
using Cpr.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca710a54ddc06b280ef817160dd6c6775c0e03a", @"/Views/LivroCaixa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164be08f5ec7ae1d113fc1966d24aeb52472d644", @"/Views/_ViewImports.cshtml")]
    public class Views_LivroCaixa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cpr.Web.ViewsModels.LivroCaixaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/dataTables-br-edit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
  
    ViewData["Title"] = "Livro Caixa";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <!-- Begin Page Content -->
        <div class=""container-fluid"">

          <!-- Page Heading -->
         <!-- <h1 class=""h3 mb-2 text-gray-800"">Tables</h1> -->
        <!--  <p class=""mb-4"">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target=""_blank"" href=""https://datatables.net"">official DataTables documentation</a>.</p> -->

          <!-- DataTales Example -->
          <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
              <h6 class=""m-0 font-weight-bold text-primary"">Livro Caixa</h6>              
            </div>            
            <div class=""card-body"">
                
              <div class=""table-responsive"">
                 <table class=""table table-hover table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
");
#nullable restore
#line 24 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                    if(@Model != null)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <thead>\n                    <tr class=\"table-info\"> \n                      <th>");
#nullable restore
#line 28 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayNameFor(model => model.CategoriaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \n                      <th>");
#nullable restore
#line 29 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                      <th>");
#nullable restore
#line 30 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                      <th>");
#nullable restore
#line 31 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                      <th>");
#nullable restore
#line 32 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                      <th style=\"text-align: center; width:  8.33%\">Editar</th> \n                      <th style=\"text-align: center; width:  8.33%\">Excluir</th>  \n                    </tr>\n                  </thead>\n");
            WriteLiteral(@"                  <tfoot>
                    <tr class=""table-info"">
                      <th></th>
                      <th></th>
                      <th></th>
                      <th class=""text-right"">Total:</th>
                      <th></th>
                      <th style=""text-align: center; width:  8.33%"">Editar</th> 
                      <th style=""text-align: center; width:  8.33%"">Excluir</th>                                            
                    </tr>
                  </tfoot>
");
#nullable restore
#line 49 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tbody>\n");
#nullable restore
#line 51 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                    if(@Model != null)
                    { 
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                       foreach (var item in Model)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <tr>\n                         <td>                          \n                          ");
#nullable restore
#line 57 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.CategoriaName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                        </td> \n                        \n                        <td>                          \n                          ");
#nullable restore
#line 61 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                        </td> \n                        <td> \n                          ");
#nullable restore
#line 64 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                      Write(item.Tipo?"Entrada":"Saída");

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                           \n                        </td> \n                          <td> \n                          ");
#nullable restore
#line 67 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \n                          </td> \n                         <td>                          \n                          ");
#nullable restore
#line 70 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                        </td> \n                        <td style=\"text-align: center;\">\n                          <a href=\"#\"  title=\"Editar\" data-id=\"");
#nullable restore
#line 73 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-primary edit"" >
                          <i class=""far fa-edit""></i></a>                         
                        </td>  
                        <td style=""text-align: center;"">
                          <a href=""#"" title=""Excluir"" data-id=""");
#nullable restore
#line 77 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger delete\" >\n                          <i class=\"fas fa-trash-alt\"></i></a>                        \n                        </td>                     \n                      </tr>               \n");
#nullable restore
#line 81 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/LivroCaixa/Index.cshtml"
                          
                    }                  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </tbody>
                </table>
              </div>
            </div>
          </div>
 <div class=""text-right "">  
  <a href=""#""  class=""btn btn-success create"">
  Nova categoria <i class=""fas fa-upload""></i></a> 

  <a href=""#""  class=""btn btn-primary createlivrocaixa"">
  Nova entrada <i class=""fas fa-upload""></i></a>    
</div> 


<div id=""modal"" class=""modal fade"" data-backdrop=""static""></div> 

    

");
            DefineSection("scripts", async() => {
                WriteLiteral("\n  \n<!-- Page level plugins -->\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca710a54ddc06b280ef817160dd6c6775c0e03a13206", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca710a54ddc06b280ef817160dd6c6775c0e03a14286", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n<!-- Page level custom scripts -->\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca710a54ddc06b280ef817160dd6c6775c0e03a15402", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n<!-- call modal -->\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca710a54ddc06b280ef817160dd6c6775c0e03a16503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>
 
 var date = new Date();
 var day = date.getDate();
 var month = date.getMonth() + 1;
 var year = date.getFullYear();

  if (month < 10) month = ""0"" + month;
    if (day < 10) day = ""0"" + day;
      var today = year + ""-"" + month + ""-"" + day;       
      document.getElementById(""Date"").value = today;
 
      var mes = month ; 
     var selecionar = '.nav-tabs a[href=""#nav-{{tab}}""]'.replace('{{tab}}', mes);
     $(selecionar).tab('show');

    //$(document).ready(function() {
  
//} );
</script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cpr.Web.ViewsModels.LivroCaixaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
