#pragma checksum "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2aa8a1ce0025d9bd85656e927669456a85b4e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
#line 1 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\_ViewImports.cshtml"
using WebApplication14_2021A;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\_ViewImports.cshtml"
using WebApplication14_2021A.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2aa8a1ce0025d9bd85656e927669456a85b4e3c", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51259f61619299b27779366595035bcaaf29d7d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Product</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2aa8a1ce0025d9bd85656e927669456a85b4e3c3813", async() => {
                WriteLiteral("\r\n    <div class=\"form-row\">\r\n        <div class=\"form-group col-md-6\">\r\n            <label for=\"ProductName\">Product Name</label>\r\n            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 308, "\"", 325, 1);
#nullable restore
#line 11 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 316, Model.Id, 316, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"text\" class=\"form-control\" id=\"ProductName\" name=\"ProductName\" placeholder=\"Product Name\"");
                BeginWriteAttribute("value", " value=\"", 445, "\"", 471, 1);
#nullable restore
#line 12 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 453, Model.ProductName, 453, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group col-md-6\">\r\n            <label for=\"Price\">Price</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"Price\" name=\"Price\" placeholder=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 677, "\"", 697, 1);
#nullable restore
#line 16 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 685, Model.Price, 685, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""DateOfPurchase"">Date of Purchase</label>
            <input type=""date"" class=""form-control"" id=""DateOfPurchase"" name=""DateOfPurchase"" placeholder=""Date of Purchase""");
                BeginWriteAttribute("value", " value=\"", 990, "\"", 1048, 1);
#nullable restore
#line 22 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 998, Model.DateOfPurchase.Value.ToString("yyyy-MM-dd"), 998, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""AvailabilityStatus"">Availability Status</label>
            <input type=""text"" class=""form-control"" id=""AvailabilityStatus"" name=""AvailabilityStatus"" placeholder=""Availability Status""");
                BeginWriteAttribute("value", " value=\"", 1319, "\"", 1352, 1);
#nullable restore
#line 26 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1327, Model.AvailabilityStatus, 1327, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""CategoryID"">Category ID</label>
            <input type=""text"" class=""form-control"" id=""CategoryID"" name=""CategoryID"" placeholder=""Category ID""");
                BeginWriteAttribute("value", " value=\"", 1623, "\"", 1648, 1);
#nullable restore
#line 32 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1631, Model.CategoryId, 1631, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group col-md-6\">\r\n            <label for=\"BrandID\">Brand ID</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"BrandID\" name=\"BrandID\" placeholder=\"Brand ID\"");
                BeginWriteAttribute("value", " value=\"", 1864, "\"", 1886, 1);
#nullable restore
#line 36 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1872, Model.BrandId, 1872, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"form-check\">\r\n            <input class=\"form-check-input\" type=\"checkbox\" id=\"Active\" name=\"Active\"");
                BeginWriteAttribute("checked", " checked=\"", 2067, "\"", 2090, 1);
#nullable restore
#line 41 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
WriteAttributeValue("", 2077, Model.Active, 2077, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" value=""true"">
            <label class=""form-check-label"" for=""Active"">
                Active
            </label>
        </div>
    </div>

    <button type=""submit"" class=""btn btn-success"">Save</button>
    <a class=""btn btn-danger"" href=""/product/index"">Cancel</a>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 95, "/product/edit/", 95, 14, true);
#nullable restore
#line 7 "C:\Users\Jafar\Desktop\CRUD Service\WebApplication14-2021A\Views\Product\Edit.cshtml"
AddHtmlAttributeValue("", 109, Model.Id, 109, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591