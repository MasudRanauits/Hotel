#pragma checksum "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e541d6c26c5c8db8b70f93f5373c11b3a07571eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Information_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Information/Create.cshtml")]
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
#line 2 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e541d6c26c5c8db8b70f93f5373c11b3a07571eb", @"/Areas/Admin/Views/Information/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb0e98ae679d497e03e04adee8ad4b49afbd1e5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Information_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel_Management.Models.Information>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mt-1 mb-1"">
                <div class=""col-sm-6 d-flex"">
                    <h1 class=""m-0 text-dark"">Information From</h1>
                </div>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card mb-5"">
                    <div class=""card-body"">
");
#nullable restore
#line 20 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
                         using (Html.BeginRouteForm("information-create", FormMethod.Post, new { enctype = "multipart/form-data" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
                       Write(Html.Partial("_Partialform", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-group row col"">
                                <div class=""col-2""></div>
                                <div class=""col-10"">
                                    <button class=""btn btn-success"" type=""submit"">Submit</button>
                                    <button class=""btn btn-danger"" >Back</button>                                 
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1317, "\"", 1352, 1);
#nullable restore
#line 31 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
WriteAttributeValue("", 1324, Url.RouteUrl("information"), 1324, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Back To List</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 34 "D:\Project\Hotel Management\Hotel Management\Areas\Admin\Views\Information\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel_Management.Models.Information> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
