#pragma checksum "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259487217dd9e0e5f7d7c449de991773bc46b266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
#line 1 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\_ViewImports.cshtml"
using Controle;

#line default
#line hidden
#line 2 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\_ViewImports.cshtml"
using Controle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259487217dd9e0e5f7d7c449de991773bc46b266", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bb41016410aec6984304bca8a544cf2691ba0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 305, true);
            WriteLiteral(@"
<h3>Cadastrar Cliente</h3>


<table class=""table table-bordered"" >
    <thead>
        <th>#</th>
        <th>ID</th>
        <th>NOME</th>
        <th>CPF</th>
        <th>ENDEREÇO</th>
        <th>CIDADE</th>
        <th>RESPONSAVEL</th>
        <th>TELEFONE</th>
        
    </thead>
");
            EndContext();
#line 21 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
       foreach (var item in (List<ClienteModel>)ViewBag.ListaCliente)
        {

#line default
#line hidden
            BeginContext(430, 119, true);
            WriteLiteral("            <tbody>\r\n                    <tr>\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 549, "\"", 594, 3);
            WriteAttributeValue("", 559, "Excluir(", 559, 8, true);
#line 25 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 567, item.IdCliente.ToString(), 567, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 593, ")", 593, 1, true);
            EndWriteAttribute();
            BeginContext(595, 52, true);
            WriteLiteral(">EXCLUIR</button></td>\r\n                        <td>");
            EndContext();
            BeginContext(648, 25, false);
#line 26 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.IdCliente.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(673, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(709, 20, false);
#line 27 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(729, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(765, 19, false);
#line 28 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.Cpf.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(784, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(820, 31, false);
#line 29 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.RuaBairroNumero.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(851, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(887, 22, false);
#line 30 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.Cidade.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(909, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(945, 27, false);
#line 31 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.Responsavel.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(972, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1008, 24, false);
#line 32 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
                       Write(item.Telefone.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1032, 82, true);
            WriteLiteral("</td>\r\n                        \r\n                    </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 36 "C:\Users\pcgamer\Desktop\Finalizando\Controle\Controle\Views\Cliente\Index.cshtml"
        }


                

#line default
#line hidden
            BeginContext(1148, 394, true);
            WriteLiteral(@"

</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CadastrarCliente()"">Cadastrar um novo cliente</button>

<script>
    function CadastrarCliente()
    {
        window.location.href = ""../Cliente/NovoCliente"";

        }
    function Excluir(idCliente)
    {
        window.location.href = ""../Cliente/ExcluirCliente/"" + idCliente;
    }

</script>
");
            EndContext();
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
