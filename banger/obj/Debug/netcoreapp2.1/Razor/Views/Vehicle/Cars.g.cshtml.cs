#pragma checksum "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b331860a97bff6beb04d6c0e53bd42ed8455d53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Cars), @"mvc.1.0.view", @"/Views/Vehicle/Cars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/Cars.cshtml", typeof(AspNetCore.Views_Vehicle_Cars))]
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
#line 1 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\_ViewImports.cshtml"
using banger;

#line default
#line hidden
#line 2 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\_ViewImports.cshtml"
using banger.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b331860a97bff6beb04d6c0e53bd42ed8455d53f", @"/Views/Vehicle/Cars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a3748b0bbd2e8f7347805fac55895f111729ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("130"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("540"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("JSOFT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("car-hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CarDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rent-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 942, true);
            WriteLiteral(@"<section id=""page-title-area"" class=""section-padding overlay"">
    <div class=""container"">
        <div class=""row"">
            <!-- Page Title Start -->
            <div class=""col-lg-12"">
                <div class=""section-title  text-center"">
                    <h2>Cars For Booking</h2>
                    <span class=""title-line""><i class=""fa fa-car""></i></span>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                </div>
            </div>
            <!-- Page Title End -->
        </div>
    </div>
</section>

<section id=""car-list-area"" class=""section-padding"">
    <div class=""container"">
        <div class=""row"">
            <!-- Car List Content Start -->
            <div class=""col-lg-12"">
                <div class=""car-list-content"">
                    <div class=""row"">
                        <!-- Single Car Start -->
                     
");
            EndContext();
#line 26 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                             foreach (var vehicle in ViewBag.cars)
                            {

#line default
#line hidden
            BeginContext(1041, 248, true);
            WriteLiteral("                                <div class=\"col-lg-6 col-md-6\">\r\n                                    <div class=\"single-car-wrap\">\r\n                                        <div class=\"p-car-thumbnails\">\r\n                                            ");
            EndContext();
            BeginContext(1289, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5d2112f0764d448bb3392bd8ad59bd", async() => {
                BeginContext(1339, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(1389, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f18ee7bd6584d699531b75eb5d58e7c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1399, "~/images/", 1399, 9, true);
#line 32 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
AddHtmlAttributeValue("", 1408, vehicle.Pic, 1408, 12, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1459, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1316, "~/images/", 1316, 9, true);
#line 31 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
AddHtmlAttributeValue("", 1325, vehicle.Pic, 1325, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1509, 191, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"car-list-info without-bar\">\r\n                                            <h2><a href=\"#\">");
            EndContext();
            BeginContext(1701, 19, false);
#line 36 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                                       Write(vehicle.VehicleType);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 62, true);
            WriteLiteral("</a></h2>\r\n                                            <h5>Rs ");
            EndContext();
            BeginContext(1783, 14, false);
#line 37 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                              Write(vehicle.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1797, 70, true);
            WriteLiteral(" Rent /per a day</h5>\r\n                                            <p>");
            EndContext();
            BeginContext(1868, 17, false);
#line 38 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                          Write(vehicle.VehicleNo);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 130, true);
            WriteLiteral("</p>\r\n                                            <ul class=\"car-info-list\">\r\n                                                <li>");
            EndContext();
            BeginContext(2016, 18, false);
#line 40 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                               Write(vehicle.Facilities);

#line default
#line hidden
            EndContext();
            BeginContext(2034, 59, true);
            WriteLiteral("</li>\r\n                                                <li>");
            EndContext();
            BeginContext(2094, 16, false);
#line 41 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                               Write(vehicle.FuelType);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 59, true);
            WriteLiteral("</li>\r\n                                                <li>");
            EndContext();
            BeginContext(2170, 15, false);
#line 42 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                               Write(vehicle.GearBox);

#line default
#line hidden
            EndContext();
            BeginContext(2185, 603, true);
            WriteLiteral(@"</li>
                                            </ul>
                                            <p class=""rating"">
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star unmark""></i>
                                            </p>
                                            ");
            EndContext();
            BeginContext(2788, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c71b854ee334cae8956b65611af84f3", async() => {
                BeginContext(2867, 7, true);
                WriteLiteral("Book It");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-num", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                                                                          WriteLiteral(vehicle.VehicleNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["num"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-num", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["num"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2878, 134, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 55 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\Cars.cshtml"
                            }

#line default
#line hidden
            BeginContext(3043, 222, true);
            WriteLiteral("\r\n\r\n                     \r\n                            <!-- Page Pagination End -->\r\n                        </div>\r\n                        <!-- Car List Content End -->\r\n                    </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591