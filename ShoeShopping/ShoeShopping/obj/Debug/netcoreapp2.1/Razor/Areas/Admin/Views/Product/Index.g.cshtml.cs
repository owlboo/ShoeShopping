#pragma checksum "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc613fd2628348f06286d9632d3073e2313260c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\_ViewImports.cshtml"
using ShoeManagement;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\_ViewImports.cshtml"
using ShoeManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc613fd2628348f06286d9632d3073e2313260c", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc97655aaec31381b8815f7c8d08bfac99e261e4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShoeShopping.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 168, true);
            WriteLiteral("\r\n<br /> <br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(252, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f4a715bc6742c397b6f4cd5c799a92", async() => {
                BeginContext(296, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(346, 152, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(499, 49, false);
#line 21 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(548, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(604, 48, false);
#line 24 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m=>m.FirstOrDefault().Image));

#line default
#line hidden
            EndContext();
            BeginContext(652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(708, 50, false);
#line 27 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Price));

#line default
#line hidden
            EndContext();
            BeginContext(758, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(814, 54, false);
#line 30 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Available));

#line default
#line hidden
            EndContext();
            BeginContext(868, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(924, 61, false);
#line 33 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().CategoryProducts));

#line default
#line hidden
            EndContext();
            BeginContext(985, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1041, 56, false);
#line 36 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().ProductTags));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1153, 51, false);
#line 39 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m=>m.FirstOrDefault().Material));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1260, 51, false);
#line 42 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1367, 51, false);
#line 45 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1474, 53, false);
#line 48 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstOrDefault().Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n");
            EndContext();
#line 53 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1658, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1719, 31, false);
#line 57 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1821, "\"", 1838, 1);
#line 60 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 1827, item.Image, 1827, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1839, 120, true);
            WriteLiteral(" width=\"100%\" style=\"border-radius:5px; border: 1px solid #bbb9b9;\" />\r\n                </td>\r\n                <td>VNĐ\r\n");
            EndContext();
#line 63 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
                     if (item.Discount > 0)
                    {
                       

#line default
#line hidden
            BeginContext(2051, 36, false);
#line 65 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
                  Write(Html.DisplayFor(m => item.New_Price));

#line default
#line hidden
            EndContext();
#line 65 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
                                                            
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(2186, 32, false);
#line 69 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
#line 69 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
                                                         
                    }

#line default
#line hidden
            BeginContext(2243, 69, true);
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2313, 36, false);
#line 75 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Available));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2417, 48, false);
#line 78 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.CategoryProducts.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2465, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2533, 43, false);
#line 81 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.ProductTags.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2576, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2644, 35, false);
#line 84 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Material));

#line default
#line hidden
            EndContext();
            BeginContext(2679, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2747, 33, false);
#line 87 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(2780, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2848, 33, false);
#line 90 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2881, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2949, 35, false);
#line 93 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(m => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(2984, 69, true);
            WriteLiteral(" %\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3053, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "caebfcaa8ebc42e19de54b8d848f9689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 96 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3107, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 99 "D:\Coding\ASP.NET\ShoeShopping\ShoeShopping\Areas\Admin\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3162, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShoeShopping.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
