#pragma checksum "C:\Users\Francesca\Desktop\Progetto_azure\Progetto_Colloquio\app_progetto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72751bc3285813b10ba81f27e0a71b53d07fd145"
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
#line 1 "C:\Users\Francesca\Desktop\Progetto_azure\Progetto_Colloquio\app_progetto\Views\_ViewImports.cshtml"
using app_progetto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francesca\Desktop\Progetto_azure\Progetto_Colloquio\app_progetto\Views\_ViewImports.cshtml"
using app_progetto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72751bc3285813b10ba81f27e0a71b53d07fd145", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fcf7c196f36589d84ace6a0bb051f2f9cd536a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Francesca\Desktop\Progetto_azure\Progetto_Colloquio\app_progetto\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.6.0/jquery.min.js""></script>
<script type=""text/javascript"">
    $(function () {
        $('#button').click(function () {
            if (!$('#iframe').length) {
                $('#iframeHolder').html('<iframe id=""iframe""src=""");
#nullable restore
#line 10 "C:\Users\Francesca\Desktop\Progetto_azure\Progetto_Colloquio\app_progetto\Views\Home\Index.cshtml"
                                                            Write(Url.Action("Privacy", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" width=\"700\" height=\"450\"></iframe>\');\r\n            }\r\n        });\r\n    });\r\n</script>\r\n\r\n<button id=\"button\">Button</button>\r\n<div id=\"iframeHolder\"></div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
