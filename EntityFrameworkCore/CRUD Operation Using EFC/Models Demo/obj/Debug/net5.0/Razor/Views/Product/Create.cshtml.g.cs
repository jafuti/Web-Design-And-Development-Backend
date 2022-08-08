#pragma checksum "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e797da764e47616c3d5a17ebcf5521eb5bbf836f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e797da764e47616c3d5a17ebcf5521eb5bbf836f", @"/Views/Product/Create.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jafar\Desktop\Models Demo\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Create Product</h2>
<form action=""/product/create"" method=""post"">
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""ProductName"">Product Name</label>
            <input type=""text"" class=""form-control"" id=""ProductName"" name=""ProductName"" placeholder=""Product Name"">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""Price"">Price</label>
            <input type=""number"" class=""form-control"" id=""Price"" name=""Price"" placeholder=""Price"">
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""DateOfPurchase"">Date of Purchase</label>
            <input type=""date"" class=""form-control"" id=""DateOfPurchase"" name=""DateOfPurchase"" placeholder=""Date of Purchase"">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""AvailabilityStatus"">Availability Status</label>
            <input type=""text"" class=""form-control"" id=""AvailabilityStatus");
            WriteLiteral(@""" name=""AvailabilityStatus"" placeholder=""Availability Status"">
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""CategoryID"">Category ID</label>
            <input type=""text"" class=""form-control"" id=""CategoryID"" name=""CategoryID"" placeholder=""Category ID"">
        </div>
        <div class=""form-group col-md-6"">
            <label for=""BrandID"">Brand ID</label>
            <input type=""text"" class=""form-control"" id=""BrandID"" name=""BrandID"" placeholder=""Brand ID"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""Active"" name=""Active"">
            <label class=""form-check-label"" for=""Active"">
                Active
            </label>
        </div>
    </div>

    <button type=""submit"" class=""btn btn-success"">Create</button>
    <a class=""btn btn-danger"" href=""/product/index"">Cancel</a>
</form>



");
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