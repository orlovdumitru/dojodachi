#pragma checksum "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30b83bea43f8f8dcbae8aa4b2f47e81055d29a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Win), @"mvc.1.0.view", @"/Views/Home/Win.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Win.cshtml", typeof(AspNetCore.Views_Home_Win))]
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
#line 1 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/_ViewImports.cshtml"
using dojodachi;

#line default
#line hidden
#line 2 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/_ViewImports.cshtml"
using dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30b83bea43f8f8dcbae8aa4b2f47e81055d29a0", @"/Views/Home/Win.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c43adf8f00d921e1e3f242ef2bcc39f1c89303", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Win : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 9, true);
            WriteLiteral("<!-- <h2>");
            EndContext();
            BeginContext(53, 17, false);
#line 4 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(70, 79, true);
            WriteLiteral("</h2> -->\r\n\r\n\r\n <br>\r\n    <br>\r\n    <div class=\"body-d\">\r\n        <h4>Fulness: ");
            EndContext();
            BeginContext(150, 14, false);
#line 10 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
                Write(Model.fullness);

#line default
#line hidden
            EndContext();
            BeginContext(164, 12, true);
            WriteLiteral(" Happiness: ");
            EndContext();
            BeginContext(177, 15, false);
#line 10 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
                                           Write(Model.happiness);

#line default
#line hidden
            EndContext();
            BeginContext(192, 8, true);
            WriteLiteral(" Meals: ");
            EndContext();
            BeginContext(201, 10, false);
#line 10 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
                                                                   Write(Model.meal);

#line default
#line hidden
            EndContext();
            BeginContext(211, 9, true);
            WriteLiteral(" Energy: ");
            EndContext();
            BeginContext(221, 12, false);
#line 10 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
                                                                                       Write(Model.energy);

#line default
#line hidden
            EndContext();
            BeginContext(233, 115, true);
            WriteLiteral("</h4>\r\n        <div class=\"containerInfo\">\r\n            <image src=\"/images/pupy.jpg\" alt=\"Pupy\"/>\r\n            <p>");
            EndContext();
            BeginContext(349, 19, false);
#line 13 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
          Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(368, 70, true);
            WriteLiteral("</p>\r\n        </div><br>\r\n        <input type=\"button\" value=\"Restart\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 438, "\"", 501, 3);
            WriteAttributeValue("", 448, "window.location.href=\'", 448, 22, true);
#line 15 "/home/dima/ownCloud/CodingDojo/c/asp/dojodachi/Views/Home/Win.cshtml"
WriteAttributeValue("", 470, Url.Action("Restart", "Home"), 470, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 500, "\'", 500, 1, true);
            EndWriteAttribute();
            BeginContext(502, 14, true);
            WriteLiteral("/>\r\n    </div>");
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
