#pragma checksum "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbacd0be5663eef08bf2940aefff3a0dba0e2ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_ViewCollectedBookings), @"mvc.1.0.view", @"/Views/Vehicle/ViewCollectedBookings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/ViewCollectedBookings.cshtml", typeof(AspNetCore.Views_Vehicle_ViewCollectedBookings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbacd0be5663eef08bf2940aefff3a0dba0e2ff", @"/Views/Vehicle/ViewCollectedBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a3748b0bbd2e8f7347805fac55895f111729ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_ViewCollectedBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<banger.Models.Bookings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnVehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
      
        Layout = "AdminLayout";
    

#line default
#line hidden
            BeginContext(92, 355, true);
            WriteLiteral(@"
    <center>
        <div class=""row m-t-30"">
            <div class=""col-md-12"">
                <!-- DATA TABLE-->
                <div class=""table-responsive m-b-40"">
                    <table class=""table table-borderless table-data3"">
                        <thead>
                            <tr>
                                <th>  ");
            EndContext();
            BeginContext(448, 45, false);
#line 14 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(493, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(539, 49, false);
#line 15 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
            EndContext();
            BeginContext(588, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(634, 46, false);
#line 16 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.PickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(680, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(726, 46, false);
#line 17 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(772, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(818, 45, false);
#line 18 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.VehicleNo));

#line default
#line hidden
            EndContext();
            BeginContext(863, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(909, 41, false);
#line 19 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(950, 45, true);
            WriteLiteral("</th>\r\n                                <th>  ");
            EndContext();
            BeginContext(996, 45, false);
#line 20 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 172, true);
            WriteLiteral("</th>\r\n                                <th>  Return Booking</th>\r\n\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1302, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1423, 44, false);
#line 31 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1595, 48, false);
#line 34 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.BookingStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1771, 45, false);
#line 37 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1944, 45, false);
#line 40 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1989, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2119, 44, false);
#line 44 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VehicleNo));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2291, 40, false);
#line 47 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2459, 44, false);
#line 50 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2630, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "417a07e6b3e84729b5e9ecea8f5dfcc3", async() => {
                BeginContext(2691, 32, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                                                                        WriteLiteral(item.BookingID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2727, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\Vehicle\ViewCollectedBookings.cshtml"
                            }

#line default
#line hidden
            BeginContext(2844, 181, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- END DATA TABLE-->\r\n            </div>\r\n        </div>\r\n    </center>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<banger.Models.Bookings>> Html { get; private set; }
    }
}
#pragma warning restore 1591