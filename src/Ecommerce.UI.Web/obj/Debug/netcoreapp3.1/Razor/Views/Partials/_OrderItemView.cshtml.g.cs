#pragma checksum "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b05f193ff94a0011442c12d55c0d21bf99d9052c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials__OrderItemView), @"mvc.1.0.view", @"/Views/Partials/_OrderItemView.cshtml")]
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
#line 1 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\_ViewImports.cshtml"
using Ecommerce.UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\_ViewImports.cshtml"
using Ecommerce.UI.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05f193ff94a0011442c12d55c0d21bf99d9052c", @"/Views/Partials/_OrderItemView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002519f39527ec4300ba0b010bd125c6e11d13c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials__OrderItemView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Domain.OrderItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lazy loaded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("order-item-quantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<tr>\r\n    <td>\r\n        <div class=\"thumb_cart\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b05f193ff94a0011442c12d55c0d21bf99d9052c4448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 107, "~/img/", 107, 6, true);
#nullable restore
#line 5 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
AddHtmlAttributeValue("", 113, Model.Product.ImagePath, 113, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 5 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
AddHtmlAttributeValue("", 164, Model.Product.ImagePath, 164, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <span class=\"item-cart\">");
#nullable restore
#line 7 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </td>\r\n    <td>\r\n        <span>R$ </span><label");
            BeginWriteAttribute("id", " id=\"", 319, "\"", 354, 2);
            WriteAttributeValue("", 324, "lblUnitPrice_", 324, 13, true);
#nullable restore
#line 10 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
WriteAttributeValue("", 337, Model.Product.Id, 337, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
                                                              Write(Model.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </td>\r\n    <td>\r\n        <div class=\"numbers-row\">\r\n            <div class=\"dec button_inc\"");
            BeginWriteAttribute("onclick", " onclick=\"", 485, "\"", 540, 3);
            WriteAttributeValue("", 495, "objThat.DecrementOrderItem(", 495, 27, true);
#nullable restore
#line 14 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
WriteAttributeValue("", 522, Model.Product.Id, 522, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 539, ")", 539, 1, true);
            EndWriteAttribute();
            WriteLiteral(">-</div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b05f193ff94a0011442c12d55c0d21bf99d9052c8431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 612, "txtQuantity_", 612, 12, true);
#nullable restore
#line 15 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
AddHtmlAttributeValue("", 624, Model.Product.Id, 624, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            WriteLiteral("quantity_");
#nullable restore
#line 15 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
                                                                                                                           WriteLiteral(Model.Product.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"inc button_inc\"");
            BeginWriteAttribute("onclick", " onclick=\"", 750, "\"", 805, 3);
            WriteAttributeValue("", 760, "objThat.IncrementOrderItem(", 760, 27, true);
#nullable restore
#line 16 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
WriteAttributeValue("", 787, Model.Product.Id, 787, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 804, ")", 804, 1, true);
            EndWriteAttribute();
            WriteLiteral(">+</div>\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <label");
            BeginWriteAttribute("id", " id=\"", 867, "\"", 909, 2);
            WriteAttributeValue("", 872, "lblTotalCostProduct_", 872, 20, true);
#nullable restore
#line 20 "C:\Users\Renan Barbosa\source\repos\EcommerceBlueModas\src\Ecommerce.UI.Web\Views\Partials\_OrderItemView.cshtml"
WriteAttributeValue("", 892, Model.Product.Id, 892, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">R$0,00</label>\r\n    </td>\r\n    <td>\r\n        <a class=\"btn btn-sm remove-item-cart\"><spam class=\"fa fa-trash\"></spam> </a>\r\n    </td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Domain.OrderItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
