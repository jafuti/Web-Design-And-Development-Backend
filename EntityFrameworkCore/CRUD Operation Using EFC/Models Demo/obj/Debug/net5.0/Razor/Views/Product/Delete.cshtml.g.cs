#pragma checksum "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd88db7a5c228495987fa81d3bfefcf645a59178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd88db7a5c228495987fa81d3bfefcf645a59178", @"/Views/Product/Delete.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication10.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete Product</h2>\r\n<form");
            BeginWriteAttribute("action", " action=\"", 115, "\"", 156, 2);
            WriteAttributeValue("", 124, "/product/delete/", 124, 16, true);
#nullable restore
#line 7 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml"
WriteAttributeValue("", 140, Model.ProductId, 140, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>\r\n                <label for=\"ProductName\">Product Name</label>\r\n            </td>\r\n            <td>\r\n                <input type=\"hidden\" name=\"ProductID\"");
            BeginWriteAttribute("value", " value=\"", 386, "\"", 410, 1);
#nullable restore
#line 14 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml"
WriteAttributeValue("", 394, Model.ProductId, 394, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                ");
#nullable restore
#line 15 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml"
           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <label for=\"Price\">Price</label>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Delete.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n\r\n    <div>Are you sure to delete this product?</div>\r\n    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n    <a class=\"btn btn-warning\" href=\"/product/index\">Cancel</a>\r\n</form>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication10.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
