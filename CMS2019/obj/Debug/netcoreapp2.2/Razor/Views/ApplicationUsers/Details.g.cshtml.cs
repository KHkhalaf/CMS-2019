#pragma checksum "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6b66e0d3c3f756f161ffa26c6a5d9527a44092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUsers_Details), @"mvc.1.0.view", @"/Views/ApplicationUsers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationUsers/Details.cshtml", typeof(AspNetCore.Views_ApplicationUsers_Details))]
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
#line 1 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\_ViewImports.cshtml"
using CMS2019;

#line default
#line hidden
#line 3 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\_ViewImports.cshtml"
using CMS2019.Models;

#line default
#line hidden
#line 4 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\_ViewImports.cshtml"
using CMS2019.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\_ViewImports.cshtml"
using CMS2019.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6b66e0d3c3f756f161ffa26c6a5d9527a44092", @"/Views/ApplicationUsers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c2995e7b1cf6a330a01331f4ace821bd181af9", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS2019.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ApplicationUser</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 43, false);
#line 14 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(257, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(301, 39, false);
#line 17 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 47, false);
#line 20 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateofBirth));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 43, false);
#line 23 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateofBirth));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(562, 39, false);
#line 26 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(645, 35, false);
#line 29 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(724, 44, false);
#line 32 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(768, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(812, 40, false);
#line 35 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 54, false);
#line 38 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(950, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(994, 50, false);
#line 41 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1088, 41, false);
#line 44 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1173, 37, false);
#line 47 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1254, 51, false);
#line 50 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1349, 47, false);
#line 53 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1440, 50, false);
#line 56 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1534, 46, false);
#line 59 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1624, 48, false);
#line 62 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1716, 44, false);
#line 65 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1804, 49, false);
#line 68 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1897, 45, false);
#line 71 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1986, 52, false);
#line 74 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2038, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2082, 48, false);
#line 77 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2174, 47, false);
#line 80 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2265, 43, false);
#line 83 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2308, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2352, 56, false);
#line 86 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2452, 52, false);
#line 89 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2548, 52, false);
#line 92 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2600, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2644, 48, false);
#line 95 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2692, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2736, 46, false);
#line 98 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(2782, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2826, 42, false);
#line 101 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(2868, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2912, 50, false);
#line 104 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2962, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3006, 46, false);
#line 107 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3052, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3096, 53, false);
#line 110 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3193, 49, false);
#line 113 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3289, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6b66e0d3c3f756f161ffa26c6a5d9527a4409219532", async() => {
                BeginContext(3335, 4, true);
                WriteLiteral("Edit");
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
#line 118 "C:\Users\hp\Documents\Visual Studio 2019\Projects\CMS2019\CMS2019\Views\ApplicationUsers\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(3343, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3351, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6b66e0d3c3f756f161ffa26c6a5d9527a4409221879", async() => {
                BeginContext(3373, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(3389, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS2019.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
