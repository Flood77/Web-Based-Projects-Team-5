#pragma checksum "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7f070514b52bbfa80f375ec52db183d18e7634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostPartialView), @"mvc.1.0.razor-page", @"/Views/Post/PostPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7f070514b52bbfa80f375ec52db183d18e7634", @"/Views/Post/PostPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef83f52754dfa702480ede5326738aae5a4a67f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostPartialView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>Post</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.SliceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.SliceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.PostText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.PostText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Likes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.Likes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Dislikes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.Dislikes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.PostDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Zachary Rapp\OneDrive - Neumont College of Computer Science\Year 2\Quarter 2\Web Projects\Web-Based-Projects-Team-5\Views\Post\PostPartialView.cshtml"
       Write(Html.DisplayFor(model => model.Post.PostDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Breaddit.Views.PostPartialViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Breaddit.Views.PostPartialViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Breaddit.Views.PostPartialViewModel>)PageContext?.ViewData;
        public Breaddit.Views.PostPartialViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
