#pragma checksum "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff682be9d5eb656bea072b8dfd4329c36c6fb27c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff682be9d5eb656bea072b8dfd4329c36c6fb27c", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication10.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form class=\"d-flex\">\r\n    <input class=\"form-control me-sm-2\" type=\"text\" placeholder=\"Search\" name=\"search\"");
            BeginWriteAttribute("value", " value=\"", 198, "\"", 221, 1);
#nullable restore
#line 7 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
WriteAttributeValue("", 206, ViewBag.search, 206, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <button class=""btn btn-secondary my-2 my-sm-0"" type=""submit"">Search</button>
</form>
<table class=""table"">
    <tr>
        <th>Product ID</th>
        <th>Product Name</th>
        <th>Product Price</th>
        <th>Date of Purchase</th>
        <th>AvailabilityStatus</th>
        <th>CategoryId</th>
        <th>BrandId</th>
        <th>Active</th>
        <th>Details</th>
        <th>Edit</th>
        <th>Delete</th>
    </tr>
");
#nullable restore
#line 24 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.DateOfPurchase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.AvailabilityStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
   Write(item.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1032, 2);
            WriteAttributeValue("", 1000, "/product/details/", 1000, 17, true);
#nullable restore
#line 36 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
WriteAttributeValue("", 1017, item.ProductId, 1017, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-outline-info\">Details</a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1144, 2);
            WriteAttributeValue("", 1115, "/product/edit/", 1115, 14, true);
#nullable restore
#line 39 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
WriteAttributeValue("", 1129, item.ProductId, 1129, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-outline-primary\">Edit</a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1258, 2);
            WriteAttributeValue("", 1227, "/product/delete/", 1227, 16, true);
#nullable restore
#line 42 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
WriteAttributeValue("", 1243, item.ProductId, 1243, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-outline-danger\">Delete</a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 45 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div class=\"text-white\">\r\n    <a href=\"/product/create\" class=\"btn btn-outline-success\">Add New Product</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication10.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591