#pragma checksum "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95015dae2c773ae70f5361ceb642a5801f7bb30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\_ViewImports.cshtml"
using ShoeManagement;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\_ViewImports.cshtml"
using ShoeManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95015dae2c773ae70f5361ceb642a5801f7bb30", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc97655aaec31381b8815f7c8d08bfac99e261e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 120, true);
            WriteLiteral("\r\n\r\n<td style=\"width:150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 252, "\"", 285, 1);
#line 8 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 259, Url.Action("Edit/"+Model), 259, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(286, 82, true);
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n        <a type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 368, "\"", 404, 1);
#line 9 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 375, Url.Action("Details/"+Model), 375, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(405, 91, true);
            WriteLiteral("><i class=\"fas fa-clipboard-list\"></i></a>\r\n        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 496, "\"", 531, 1);
#line 10 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 503, Url.Action("Delete/"+Model), 503, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 58, true);
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n    </div>\r\n</td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
