#pragma checksum "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d8a9dce512b3a8cadd725e7cbadd67f77d9e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductListPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductListPartial.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\_ViewImports.cshtml"
using P228Allup.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d8a9dce512b3a8cadd725e7cbadd67f77d9e5a", @"/Views/Shared/_ProductListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bea41565a21897b038784c4801e8d3ebb9f826", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addtobasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addtobasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productModalBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#productQuickModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "modal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-items\">\r\n    <div class=\"row product-active\">\r\n");
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
         for (int i = 0; i < (int)Math.Ceiling((decimal)Model.Count() / 2); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 8 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                 foreach (Product product in Model.Skip(i * 2).Take(2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-product mt-30\">\r\n                        <div class=\"product-image\">\r\n                            <a href=\"single-product.html\">\r\n                                <img class=\"first-image\"");
            BeginWriteAttribute("src", " src=\"", 544, "\"", 590, 2);
            WriteAttributeValue("", 550, "assets/images/product/", 550, 22, true);
#nullable restore
#line 13 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 572, product.MainImage, 572, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\">\r\n                                <img class=\"second-image\"");
            BeginWriteAttribute("src", " src=\"", 665, "\"", 712, 2);
            WriteAttributeValue("", 671, "assets/images/product/", 671, 22, true);
#nullable restore
#line 14 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 693, product.HoverImage, 693, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\">\r\n                            </a>\r\n                            <ul class=\"product-meta\">\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d8a9dce512b3a8cadd725e7cbadd67f77d9e5a8854", async() => {
                WriteLiteral("<i class=\"icon ion-bag\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                                                                              WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                <li><a href=\"#\"><i class=\"icon ion-android-favorite-outline\"></i></a></li>\r\n                                <li><a href=\"#\"><i class=\"icon ion-android-options\"></i></a></li>\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d8a9dce512b3a8cadd725e7cbadd67f77d9e5a11662", async() => {
                WriteLiteral("<i class=\"icon ion-android-open\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                                                                                                                               WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            </ul>\r\n");
#nullable restore
#line 22 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                             if (product.DiscountedPrice > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"discount-product\">-");
#nullable restore
#line 24 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                            Write((((product.Price * 100) / product.DiscountedPrice) - 100).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 25 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""product-content"">
                            <ul class=""product-rating"">
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                                <li class=""rating-on""><i class=""fas fa-star""></i></li>
                            </ul>
                            <h4 class=""product-title""><a href=""single-product.html"">");
#nullable restore
#line 35 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                                               Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <div class=\"product-price\">\r\n");
#nullable restore
#line 37 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                 if (product.DiscountedPrice > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"regular-price \">€");
#nullable restore
#line 39 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"price-sale\">€");
#nullable restore
#line 40 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                         Write(product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 41 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"price-sale\">€");
#nullable restore
#line 44 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                                         Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 45 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div> <!-- single product -->\r\n");
#nullable restore
#line 49 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 51 "C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\Views\Shared\_ProductListPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> <!-- row -->\r\n</div> <!-- product items -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
