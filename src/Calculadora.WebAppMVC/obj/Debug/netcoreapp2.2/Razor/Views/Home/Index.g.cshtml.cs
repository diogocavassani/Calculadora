#pragma checksum "D:\Projetos - PontoSys\Calculadora\src\Calculadora.WebAppMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a05985cfdcdfae98e606cb563c03c32886068a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Projetos - PontoSys\Calculadora\src\Calculadora.WebAppMVC\Views\_ViewImports.cshtml"
using Calculadora.WebAppMVC;

#line default
#line hidden
#line 2 "D:\Projetos - PontoSys\Calculadora\src\Calculadora.WebAppMVC\Views\_ViewImports.cshtml"
using Calculadora.WebAppMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a05985cfdcdfae98e606cb563c03c32886068a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6cee5ce995371548e2e90e60487345a6fdb7690", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projetos - PontoSys\Calculadora\src\Calculadora.WebAppMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 3461, true);
            WriteLiteral(@"
<div class=""text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-3""></div>
            <div class=""col-6"">
                
                <div class=""row row-bottom-15"">
                   <div class=""col-12"">
                       <input type=""number"" class=""form-control"" id=""visorCalculadora"">
                   </div> 
                </div>

                <div class=""row row-bottom-15"">
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">7</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">8</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">9</button>
                    </div>
                    <div class=""col-3"">
                        <button");
            WriteLiteral(@" type=""button"" class=""btn btn-info w-100 btn-operacao"">X</button>
                    </div>

                </div>

                <div class=""row row-bottom-15"">
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero btn-numero"">4</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">5</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">6</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-info w-100 btn-operacao"">-</button>
                    </div>
                </div>

                <div class=""row row-bottom-15"">
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-da");
            WriteLiteral(@"rk w-100 btn-numero"">1</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">2</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">3</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-info w-100 btn-operacao"">+</button>
                    </div>
                </div>

                <div class=""row row-bottom-15"">
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-danger w-100"">CE</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-dark w-100 btn-numero"">0</button>
                    </div>
                    <div class=""col-3"">
                        <but");
            WriteLiteral(@"ton type=""button"" class=""btn btn-success w-100 btn-operacao"">=</button>
                    </div>
                    <div class=""col-3"">
                        <button type=""button"" class=""btn btn-info w-100 btn-operacao"">/</button>
                    </div>
                </div>
            </div>
            <div class=""col-3""></div>
        </div>
    </div>

</div>
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
