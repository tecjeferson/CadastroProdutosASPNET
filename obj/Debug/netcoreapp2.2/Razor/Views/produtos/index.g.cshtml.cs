#pragma checksum "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2d8d82fd62ce003a1c8f86598d9efdd9a836bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_produtos_index), @"mvc.1.0.view", @"/Views/produtos/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/produtos/index.cshtml", typeof(AspNetCore.Views_produtos_index))]
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
#line 1 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\_ViewImports.cshtml"
using CadastroProduto;

#line default
#line hidden
#line 2 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\_ViewImports.cshtml"
using CadastroProduto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2d8d82fd62ce003a1c8f86598d9efdd9a836bd", @"/Views/produtos/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e29cb12ed28ca2a35071af08fb93f41837e501", @"/Views/_ViewImports.cshtml")]
    public class Views_produtos_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroProduto.Models.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 582, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col"">
            <h1>Produtos</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-striped table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Nome</th>
                        <th scope=""col"">Quantidade</th>
                        <th scope=""col"">Estado</th>
                    </tr>
                </thead>
                <tbody"">
");
            EndContext();
#line 19 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                     foreach(var produto in Model)
                    {

#line default
#line hidden
            BeginContext(709, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(764, 10, false);
#line 22 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                       Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(774, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(810, 12, false);
#line 23 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(822, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(858, 18, false);
#line 24 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                       Write(produto.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(876, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(912, 14, false);
#line 25 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                       Write(produto.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(926, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 27 "C:\Users\jefbg\OneDrive\projetos\CSharp\CadastroProduto\Views\produtos\index.cshtml"
                    }

#line default
#line hidden
            BeginContext(983, 78, true);
            WriteLiteral("                    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroProduto.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
