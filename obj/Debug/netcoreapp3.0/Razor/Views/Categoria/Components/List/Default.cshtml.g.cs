#pragma checksum "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b323e66291cb1d32cba0136b7eed1830c9a4c981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Components_List_Default), @"mvc.1.0.view", @"/Views/Categoria/Components/List/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b323e66291cb1d32cba0136b7eed1830c9a4c981", @"/Views/Categoria/Components/List/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164be08f5ec7ae1d113fc1966d24aeb52472d644", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Components_List_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cpr.Web.ViewsModels.CategoriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
  
    ViewData["Title"] = "Home Page";

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
              <h6 class=""m-0 font-weight-bold text-primary"">Tabela Categoria</h6>              
            </div>            
            <div class=""card-body"">
                
              <div class=""table-responsive"">
                <table class=""table table-hover table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                  <thead>
                    <tr class=""table-info"">                      
                      <th>");
#nullable restore
#line 24 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
                     Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                      <th style=""text-align: center; width:  8.33%"">Editar</th> 
                      <th style=""text-align: center; width:  8.33%"">Excluir</th>                 
                    </tr>
                  </thead>
                  <tfoot>
                   
                    <tr class=""table-info"">
                      <th></th>
                      <th style=""text-align: center; width:  8.33%"">Editar</th> 
                      <th style=""text-align: center; width:  8.33%"">Excluir</th>                                            
                    </tr>
                  
                  </tfoot>
                  <tbody>
");
#nullable restore
#line 39 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
                   foreach (var item in Model)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                      <td>                          \n                          ");
#nullable restore
#line 43 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                      </td> \n                      <td style=\"text-align: center;\">\n                          <a href=\"#\"  title=\"Editar\" data-id=\"");
#nullable restore
#line 46 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
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
#line 50 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger delete\" >\n                            <i class=\"fas fa-trash-alt\"></i></a>                        \n                      </td>                     \n                    </tr>               \n");
#nullable restore
#line 54 "/home/glaulher/Documentos/dev/Projetos/Cpr/src/Cpr.Web/Views/Categoria/Components/List/Default.cshtml"
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
                   <a href=""#"" class=""btn btn-success create"">
                   Nova categoria <i class=""fas fa-upload""></i></a>    
                 </div>    
        </div>
        <!-- /.container-fluid -->

    <div id=""modal"" class=""modal fade"" data-backdrop=""static""></div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cpr.Web.ViewsModels.CategoriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
