#pragma checksum "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9f8efb1a16a9011c1e1e78e75a838351dc5647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
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
#line 1 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\_ViewImports.cshtml"
using HandsOnModelValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\_ViewImports.cshtml"
using HandsOnModelValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9f8efb1a16a9011c1e1e78e75a838351dc5647", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb1a0d051628c589caf6b7f9a1d52b5e973d730", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnModelValidation.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 7 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 11 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 21 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 31 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 36 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 41 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 42 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 43 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\"value=\"Register\"class=\"btn btn-primary\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 51 "C:\Suma\c#\ASP.Net Core\HandsOnModelValidation\Views\Account\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnModelValidation.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
