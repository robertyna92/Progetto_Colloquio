#pragma checksum "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d069ca313527e4e3b2ce91a70bbcb3f859badf8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\_ViewImports.cshtml"
using app_progetto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\_ViewImports.cshtml"
using app_progetto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d069ca313527e4e3b2ce91a70bbcb3f859badf8f", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fcf7c196f36589d84ace6a0bb051f2f9cd536a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app_progetto.Models.ApiContent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1> NASA Astronomy Picture Of The Days</h1>\r\n\r\n<h2>  ");
#nullable restore
#line 5 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
 Write(Html.DisplayFor(item => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p> Date: ");
#nullable restore
#line 6 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
     Write(Html.DisplayFor(item => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 193, "\"", 235, 1);
#nullable restore
#line 7 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 199, Html.DisplayFor(item => item.hdurl), 199, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500\" ; height=\"500\" />\r\n<p> explanation: ");
#nullable restore
#line 8 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
            Write(Html.DisplayFor(item => item.explanation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>  ");
#nullable restore
#line 9 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
Write(Html.DisplayFor(item => item.media_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 389, "\"", 429, 1);
#nullable restore
#line 10 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 395, Html.DisplayFor(item => item.url), 395, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<p> Copriryght: ");
#nullable restore
#line 11 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
           Write(Html.DisplayFor(item => item.copyright));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p> service_version: ");
#nullable restore
#line 12 "C:\Users\Francesca\source\repos\app_progetto\app_progetto\Views\Home\Privacy.cshtml"
                Write(Html.DisplayFor(item => item.service_version));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app_progetto.Models.ApiContent> Html { get; private set; }
    }
}
#pragma warning restore 1591
