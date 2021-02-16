#pragma checksum "C:\Users\Walter Cubero\Source\Repos\Plantilla_NetcoreAPISwagger\Plantilla.NetCoreSwaggerBasicAuth.FrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae59a7a9b73ce9140bf0fedd63224985240beec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Walter Cubero\Source\Repos\Plantilla_NetcoreAPISwagger\Plantilla.NetCoreSwaggerBasicAuth.FrontEnd\Views\_ViewImports.cshtml"
using Plantilla.NetCoreSwaggerBasicAuth.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Walter Cubero\Source\Repos\Plantilla_NetcoreAPISwagger\Plantilla.NetCoreSwaggerBasicAuth.FrontEnd\Views\_ViewImports.cshtml"
using Plantilla.NetCoreSwaggerBasicAuth.FrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae59a7a9b73ce9140bf0fedd63224985240beec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4127ee160ecaad3a1a7d5713c7d07fc09dc82d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Walter Cubero\Source\Repos\Plantilla_NetcoreAPISwagger\Plantilla.NetCoreSwaggerBasicAuth.FrontEnd\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">

    $(function () {

        $(""[id*='id_btn_example']"").click(function () {

            listado_employee_ejemplo();

        });

    });

    function cargar_tabla(data) {

        debugger

        $('#id_table').DataTable().destroy();

        $('#id_table tbody').empty();


        for (var i = 0; i < data.model.length; i++)
        {
            var row = data.model[i];

            var items = ""<tr>"";
            items += ""<td>"" + row.id + ""</td>"";
            items += ""<td>"" + row.name + ""</td>"";
            items += ""<td>"" + row.email + ""</td>"";
            items += ""</tr> "";

            $(""#id_table > tbody"").append(items);

        }


        var table = $(""#id_table"").DataTable({            
            ""order"": [[1, ""desc""]]
        });




    }

    function listado_employee_ejemplo() {

        var sucessResponse = function (data) {

            cargar_tabla(data);
            
        };

        var ");
            WriteLiteral(@"employee = {
            Id: ""1"",
            Name: ""name ejemplo""
        };

        ajax_method(""/Home/ListdoEmployee"", employee, sucessResponse, errorResponse);
    }



</script>

<div class=""alert alert-info"" role=""alert"">
    <strong>Consideracion!</strong> 
    <br />

    <ul>
        <li>Esto es un Ejemplo de un Proyecto Front comunicandose con un Servicio, en donde la lógica reside en el servicio</li>
        <li>El FrontEnd se separa como una capa independiente, estpo permite comunicar a los usuarios con el FrontEnd, pero tambien extiende su uso y comunicacion entre sistemas, atraves del Microservicio</li>
        <li>Para probar este Ejmplo, se debe primero levantar el Proyecto [Plantilla.NetCoreSwaggerBasicAuth.Servicio], que será consultado desde este FrontEnd</li>
        <li>Este será el estandar de desarrollo para las aplicaciones</li>
        <li>Esta Arquitectura permite centrar el esfuerzo en la lógica de negocio y estandarizar el desarrollo</li>
    </ul>

</div>");
            WriteLiteral(@"

<button id=""id_btn_example"" type=""button"" class=""btn btn-lg btn-primary"">Ejemplo Request al Servicio</button>


<table id=""id_table"" class=""display"" style=""width:100%"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Email</th>

        </tr>
    </thead>
    <tbody>
    </tbody>
    <tfoot>
        <tr>
            <th></th>
            <th></th>
            <th></th>
        </tr>
    </tfoot>
</table>
");
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
