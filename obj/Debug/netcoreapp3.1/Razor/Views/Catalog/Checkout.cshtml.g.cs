#pragma checksum "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91550b577e189d2f2b49fb00b91ebf903d628147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Checkout), @"mvc.1.0.view", @"/Views/Catalog/Checkout.cshtml")]
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
#line 1 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\_ViewImports.cshtml"
using asp.NetLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\_ViewImports.cshtml"
using asp.NetLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91550b577e189d2f2b49fb00b91ebf903d628147", @"/Views/Catalog/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6227edf04bfdbda245babd6156a36fa364858a", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asp.NetLibrary.Models.Checkout.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 85, "\"", 91, 0);
                EndWriteAttribute();
                BeginWriteAttribute("intergrity", " intergrity=\"", 92, "\"", 105, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 129, "\"", 135, 0);
                EndWriteAttribute();
                BeginWriteAttribute("intergrity", " intergrity=\"", 136, "\"", 149, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 173, "\"", 179, 0);
                EndWriteAttribute();
                BeginWriteAttribute("intergrity", " intergrity=\"", 180, "\"", 193, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""card-header clearfix detailHeading"">
        <h2 class=""text-muted"">Checkout Library Item</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
#nullable restore
#line 21 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 601, "\"", 622, 1);
#nullable restore
#line 22 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
WriteAttributeValue("", 607, Model.ImageUrl, 607, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\" col-md-9\">\r\n");
#nullable restore
#line 26 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
                 using (Html.BeginForm("PlaceCheckout", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        Please insert a Library Card Id.\r\n                        ");
#nullable restore
#line 31 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-success btn-lg\">Check out</button>\r\n                    </div>\r\n");
#nullable restore
#line 36 "C:\Users\jayuc\Desktop\Program practice\c#\asp.NetLibrary\Views\Catalog\Checkout.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asp.NetLibrary.Models.Checkout.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
