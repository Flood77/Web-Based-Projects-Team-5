#pragma checksum "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7777fdccd94aafb78e2844b3096e20c89290a3a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Details), @"mvc.1.0.view", @"/Views/Post/Details.cshtml")]
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
#line 1 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\_ViewImports.cshtml"
using Breaddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\_ViewImports.cshtml"
using Breaddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7777fdccd94aafb78e2844b3096e20c89290a3a0", @"/Views/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef83f52754dfa702480ede5326738aae5a4a67f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Breaddit.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"post-container\">\r\n    <p>\"s/\"");
#nullable restore
#line 11 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
      Write(ViewBag.SliceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3 class=\"header-container\">");
#nullable restore
#line 12 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
                            Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <hr />\r\n\r\n");
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 41 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
     foreach (var item in ViewBag.Comments)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
   Write(Html.Partial("../Comment/CommentPartialView", (Comment)item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Views\Post\Details.cshtml"
                                                                     ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Breaddit.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
