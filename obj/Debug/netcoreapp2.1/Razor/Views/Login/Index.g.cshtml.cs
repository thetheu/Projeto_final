#pragma checksum "C:\Users\44056839808\Documents\Senai\Nova pasta\Projeto_final\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0150c1e86c19a8e6962d926ec058f47dbacc780b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0150c1e86c19a8e6962d926ec058f47dbacc780b", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\44056839808\Documents\Senai\Nova pasta\Projeto_final\Views\Login\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 144, true);
            WriteLiteral("    <link rel=\"stylesheet\" href=\"css/login.css\">\r\n\r\n    <section id=\"cadastro\">\r\n       \r\n            <div id=\"area\">\r\n                    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 176, "\'", 214, 1);
#line 9 "C:\Users\44056839808\Documents\Senai\Nova pasta\Projeto_final\Views\Login\Index.cshtml"
WriteAttributeValue("", 185, Url.Action("Logar", "Login"), 185, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(215, 1240, true);
            WriteLiteral(@" method=""POST"" id=""formulario"" autocomplete=""off"">
                      <fieldset>
                        <legend>Login</legend>
                        <div><label class=""email"">Email:</label><input class=""campo_email"" type=""text"" name=""email"" required><br></div>
                         <div><label class=""senha"">Senha:</label><input class=""campo_senha"" type=""text"" name=""senha"" required><br></div>
                        <input type=""submit"" value=""Enviar"" class=""enviar"">
                      </fieldset>
                    </form>
                </div>
            </section>
            <section>

                <p>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br>
                ");
            WriteLiteral("    <br>\r\n                    <br>\r\n                    <br>\r\n                    <br>\r\n                    <br>\r\n                    <br>\r\n                </p>.\r\n                \r\n            </section>\r\n\r\n\r\n</html>");
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