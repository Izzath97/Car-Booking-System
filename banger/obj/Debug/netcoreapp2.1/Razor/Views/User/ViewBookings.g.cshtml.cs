#pragma checksum "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565a7ad5c9e4360c3028fef74a5ddb62f8843c2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewBookings), @"mvc.1.0.view", @"/Views/User/ViewBookings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ViewBookings.cshtml", typeof(AspNetCore.Views_User_ViewBookings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565a7ad5c9e4360c3028fef74a5ddb62f8843c2f", @"/Views/User/ViewBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a3748b0bbd2e8f7347805fac55895f111729ec", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<banger.Models.Bookings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(76, 553, true);
            WriteLiteral(@"
<section id=""page-title-area"" class=""section-padding overlay"">
    <div class=""container"">
        <div class=""row"">
            <!-- Page Title Start -->
            <div class=""col-lg-12"">
                <div class=""section-title  text-center"">
                    <h2>My Bookings</h2>
                    <span class=""title-line""><i class=""fa fa-car""></i></span>
                    <p>Banger and Co Bookings</p>
                </div>
            </div>
            <!-- Page Title End -->
        </div>
    </div>
</section>


");
            EndContext();
#line 23 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
  

    if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(671, 185, true);
            WriteLiteral("        <div class=\"section-title  text-center\">\r\n            <br>\r\n            <h2>No Bookings</h2>\r\n            <span class=\"title-line\"><i class=\"fa fa-car\"></i></span>\r\n            ");
            EndContext();
            BeginContext(856, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12ca7e9c6c7440c82ab2bc132fbbc93", async() => {
                BeginContext(902, 17, true);
                WriteLiteral("  <p>Book Now</p>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"


    }

    else
    {

#line default
#line hidden
            BeginContext(971, 136, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1108, 45, false);
#line 43 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 55, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1209, 49, false);
#line 45 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 33, true);
            WriteLiteral("</th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1292, 46, false);
#line 46 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.PickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 33, true);
            WriteLiteral("</th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1372, 46, false);
#line 47 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 33, true);
            WriteLiteral("</th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1452, 45, false);
#line 48 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.VehicleNo));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 33, true);
            WriteLiteral("</th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1531, 41, false);
#line 49 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 33, true);
            WriteLiteral("</th>\r\n                    <th>  ");
            EndContext();
            BeginContext(1606, 45, false);
#line 50 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                     Write(Html.DisplayNameFor(model => model.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 158, true);
            WriteLiteral("</th>\r\n                    <th>\r\n                        Delete\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 57 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1874, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1959, 44, false);
#line 61 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2095, 48, false);
#line 64 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BookingStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2235, 45, false);
#line 67 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(2280, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2372, 45, false);
#line 70 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2511, 44, false);
#line 74 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.VehicleNo));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2647, 40, false);
#line 77 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2779, 44, false);
#line 80 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(2823, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2916, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05095d5c9ccb44b3b8e2f423c43b7935", async() => {
                BeginContext(3066, 51, true);
                WriteLiteral("<i class=\"fa fa-trash-alt fa-lg\"></i>Cancel Booking");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                                                            WriteLiteral(item.BookingID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3121, 62, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
                }

#line default
#line hidden
            BeginContext(3202, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 91 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"

    }

#line default
#line hidden
            BeginContext(3254, 296, true);
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""section-title  text-center"">
        <h2>My Bookings History</h2>
        <span class=""title-line""><i class=""fa fa-car""></i></span>

    </div>
</div>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(3551, 45, false);
#line 106 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.BookingID));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 39, true);
            WriteLiteral("\r\n            </th>\r\n            <th>  ");
            EndContext();
            BeginContext(3636, 46, false);
#line 108 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.PickUpDate));

#line default
#line hidden
            EndContext();
            BeginContext(3682, 25, true);
            WriteLiteral("</th>\r\n            <th>  ");
            EndContext();
            BeginContext(3708, 46, false);
#line 109 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(3754, 25, true);
            WriteLiteral("</th>\r\n            <th>  ");
            EndContext();
            BeginContext(3780, 45, false);
#line 110 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.VehicleNo));

#line default
#line hidden
            EndContext();
            BeginContext(3825, 25, true);
            WriteLiteral("</th>\r\n            <th>  ");
            EndContext();
            BeginContext(3851, 41, false);
#line 111 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3892, 25, true);
            WriteLiteral("</th>\r\n            <th>  ");
            EndContext();
            BeginContext(3918, 45, false);
#line 112 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.Equipment));

#line default
#line hidden
            EndContext();
            BeginContext(3963, 25, true);
            WriteLiteral("</th>\r\n            <th>  ");
            EndContext();
            BeginContext(3989, 42, false);
#line 113 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
             Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(4031, 51, true);
            WriteLiteral("</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 118 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
         foreach (Bookings bookings in ViewBag.booking)
        {

#line default
#line hidden
            BeginContext(4150, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4199, 18, false);
#line 122 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.BookingID);

#line default
#line hidden
            EndContext();
            BeginContext(4217, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4275, 19, false);
#line 126 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.PickUpDate);

#line default
#line hidden
            EndContext();
            BeginContext(4294, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4350, 19, false);
#line 129 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.ReturnDate);

#line default
#line hidden
            EndContext();
            BeginContext(4369, 59, true);
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4429, 18, false);
#line 134 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.VehicleNo);

#line default
#line hidden
            EndContext();
            BeginContext(4447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4503, 18, false);
#line 137 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.LicenseNo);

#line default
#line hidden
            EndContext();
            BeginContext(4521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4577, 18, false);
#line 140 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
           Write(bookings.Equipment);

#line default
#line hidden
            EndContext();
            BeginContext(4595, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n              RS :  ");
            EndContext();
            BeginContext(4655, 15, false);
#line 143 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
               Write(bookings.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(4670, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 147 "C:\Users\Izzath\Documents\Visual Studio 2017\Projects\banger\banger\Views\User\ViewBookings.cshtml"
        }

#line default
#line hidden
            BeginContext(4719, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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