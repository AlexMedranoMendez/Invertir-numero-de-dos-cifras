#pragma checksum "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc195aa1db211860553f33332af0b1513e70004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvNumero_Index), @"mvc.1.0.view", @"/Views/InvNumero/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc195aa1db211860553f33332af0b1513e70004", @"/Views/InvNumero/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4208cf12cc68e8567e72877a21b2ffbbd3bf49", @"/Views/_ViewImports.cshtml")]
    public class Views_InvNumero_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ejercicio1.Models.InvertirNumero>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc195aa1db211860553f33332af0b1513e700043410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc195aa1db211860553f33332af0b1513e700044337", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml"
         using (Html.BeginForm("Index", "InvNumero", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1>Inversion de un numero de dos digitos</h1>\r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"Num\">Numero:</label>\r\n                <input type=\"number\" id=\"Num\" class=\"form-control\" name=\"Num\" min=\"10\" max=\"99\"");
                BeginWriteAttribute("value", " value=\"", 466, "\"", 484, 1);
#nullable restore
#line 16 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml"
WriteAttributeValue("", 474, Model.Num, 474, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>                      \r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"InvNum\">Numero Invertido:</label>\r\n                <input type=\"text\" id=\"InvNum\" class=\"form-control\" name=\"InvNum\"");
                BeginWriteAttribute("value", " value=\"", 716, "\"", 737, 1);
#nullable restore
#line 21 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml"
WriteAttributeValue("", 724, Model.InvNum, 724, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly/>\r\n            </div>\r\n");
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-info\" id=\"inv\" value=\"inv\" name=\"inversion\">Invertir</button>\r\n");
#nullable restore
#line 25 "C:\Users\user\Desktop\prog3\Ejercicio1\Views\InvNumero\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ejercicio1.Models.InvertirNumero> Html { get; private set; }
    }
}
#pragma warning restore 1591
