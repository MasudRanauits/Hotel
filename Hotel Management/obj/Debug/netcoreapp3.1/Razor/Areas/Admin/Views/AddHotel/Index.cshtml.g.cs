#pragma checksum "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cebd802425de62e4eff13a5e3c889144349dcea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddHotel_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddHotel/Index.cshtml")]
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
#line 1 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
using Hotel_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cebd802425de62e4eff13a5e3c889144349dcea5", @"/Areas/Admin/Views/AddHotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb0e98ae679d497e03e04adee8ad4b49afbd1e5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AddHotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AddHotels>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n<header>\r\n    <div class=\"row px-md-2\">\r\n        <div class=\"col-6\">\r\n            <h1 class=\"text-dark\">Hotel List</h1>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cebd802425de62e4eff13a5e3c889144349dcea54928", async() => {
                WriteLiteral("&nbsp;Add New Hotel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</header>\r\n\r\n<br /><br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cebd802425de62e4eff13a5e3c889144349dcea56244", async() => {
                WriteLiteral(@"
<div class=""card-content collapse show "">
                    <div class=""card-body"">                       
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered datatable-select-inputs"" id=""myTable"">
                                <thead>
                                    <tr>
                                        <th>
                                            ");
#nullable restore
#line 28 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.HotelName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 31 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 34 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 37 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.ContactNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 40 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.FaxNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 43 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 46 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.VatRegNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 49 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.EmailAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 52 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.AreaCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 55 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.RestaurantName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 58 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.Capacity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 61 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.SSLStoreId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 64 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                       Write(Html.DisplayNameFor(model =>model.SSLPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </th>
                                        
                                        <th>
                                            Action
                                        </th>
                                        <th>

                                        </th>
                                    </tr>
                                </thead>                                
                                <tbody>
");
#nullable restore
#line 76 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 79 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.HotelName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 80 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 81 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.ContactNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 83 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.FaxNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 84 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 85 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.VatRegNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 86 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.EmailAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 87 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.AreaCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 88 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.RestaurantName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 89 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.Capacity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 90 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                           Write(item.SSLStoreId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                             <td>");
#nullable restore
#line 91 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                            Write(item.SSLPassword);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cebd802425de62e4eff13a5e3c889144349dcea517703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 93 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 96 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\AddHotel\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n\r\n                                <tfoot>\r\n");
                WriteLiteral("                                </tfoot>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AddHotels>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591