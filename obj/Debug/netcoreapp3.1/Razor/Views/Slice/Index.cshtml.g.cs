#pragma checksum "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47aa57d069765cbbe5130f94a20bd93c470cf720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slice_Index), @"mvc.1.0.view", @"/Views/Slice/Index.cshtml")]
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
#line 1 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\_ViewImports.cshtml"
using Breaddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\_ViewImports.cshtml"
using Breaddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47aa57d069765cbbe5130f94a20bd93c470cf720", @"/Views/Slice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef83f52754dfa702480ede5326738aae5a4a67f", @"/Views/_ViewImports.cshtml")]
    public class Views_Slice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Breaddit.Models.Slice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
Write(Html.ActionLink("Create new", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Followers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Followers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 48 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.ActionLink("Details", "Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.ActionLink("Create post", "Create", "Post", new { item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Slice\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Breaddit.Models.Slice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
