#pragma checksum "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5f736b5f67241b380031c4131cd6a6192567b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Northwind_ProductView), @"mvc.1.0.view", @"/Views/Northwind/ProductView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Northwind/ProductView.cshtml", typeof(AspNetCore.Views_Northwind_ProductView))]
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
#line 1 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\_ViewImports.cshtml"
using _10_21_ProductsDapper;

#line default
#line hidden
#line 2 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\_ViewImports.cshtml"
using _10_21_ProductsDapper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5f736b5f67241b380031c4131cd6a6192567b3b", @"/Views/Northwind/ProductView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97abb00f4153540029a752563208cd459af14ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Northwind_ProductView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_10_21_ProductsDapper.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Northwind", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProductView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProductResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
  
    ViewData["Title"] = "ProductView";

#line default
#line hidden
            BeginContext(94, 132, true);
            WriteLiteral("\r\n<h1>ProductView</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(227, 45, false);
#line 14 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(272, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(334, 41, false);
#line 17 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(375, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(436, 47, false);
#line 20 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(483, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(545, 43, false);
#line 23 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(588, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(649, 46, false);
#line 26 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(695, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(757, 42, false);
#line 29 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(799, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(860, 46, false);
#line 32 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(906, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(968, 42, false);
#line 35 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1071, 51, false);
#line 38 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1184, 47, false);
#line 41 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1292, 45, false);
#line 44 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1399, 41, false);
#line 47 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1501, 48, false);
#line 50 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1611, 44, false);
#line 53 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1716, 48, false);
#line 56 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1826, 44, false);
#line 59 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1931, 48, false);
#line 62 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2041, 44, false);
#line 65 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2146, 48, false);
#line 68 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2256, 44, false);
#line 71 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
       Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2334, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f736b5f67241b380031c4131cd6a6192567b3b13677", async() => {
                BeginContext(2430, 132, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Update\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
                                                                      WriteLiteral(Model.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2569, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(2577, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f736b5f67241b380031c4131cd6a6192567b3b16672", async() => {
                BeginContext(2675, 132, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
                                                                        WriteLiteral(Model.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2814, 23, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2838, 68, false);
#line 89 "D:\GrandCircus\Lectures\10_21_ProductsDapper\Views\Northwind\ProductView.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2914, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f736b5f67241b380031c4131cd6a6192567b3b20070", async() => {
                BeginContext(2936, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2952, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_10_21_ProductsDapper.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
