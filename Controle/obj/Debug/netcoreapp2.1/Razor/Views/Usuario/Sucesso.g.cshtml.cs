#pragma checksum "C:\Users\pcgamer\Desktop\Finalizado\Controle\Controle\Views\Usuario\Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fcfcacde1fc873d8f95455a83a1fd567d27e000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Sucesso), @"mvc.1.0.view", @"/Views/Usuario/Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Sucesso.cshtml", typeof(AspNetCore.Views_Usuario_Sucesso))]
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
#line 1 "C:\Users\pcgamer\Desktop\Finalizado\Controle\Controle\Views\_ViewImports.cshtml"
using Controle;

#line default
#line hidden
#line 2 "C:\Users\pcgamer\Desktop\Finalizado\Controle\Controle\Views\_ViewImports.cshtml"
using Controle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fcfcacde1fc873d8f95455a83a1fd567d27e000", @"/Views/Usuario/Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bb41016410aec6984304bca8a544cf2691ba0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 183, true);
            WriteLiteral("\r\n\r\n\r\n<style>\r\n    #background {\r\n        background-image: url(../images/login2.jpg);\r\n        background-repeat: no-repeat;\r\n        background-size: 100% 219%;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\pcgamer\Desktop\Finalizado\Controle\Controle\Views\Usuario\Sucesso.cshtml"
          
            Layout = "../Shared/_layoutLogin.cshtml";



     



        

#line default
#line hidden
            BeginContext(280, 185, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        <h2>\r\n            Parabens sua conta foi criada com sucesso!\r\n            clique <a href=\"../Usuario/Login\"> aqui </a> para efetuar login no sistema\r\n        </h2>\r\n\r\n");
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
