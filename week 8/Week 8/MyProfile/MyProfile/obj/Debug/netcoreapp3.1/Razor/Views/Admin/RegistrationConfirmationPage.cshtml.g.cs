#pragma checksum "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\RegistrationConfirmationPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d869add53a4fe53a9950c7975f8327b139bf545f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegistrationConfirmationPage), @"mvc.1.0.view", @"/Views/Admin/RegistrationConfirmationPage.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\_ViewImports.cshtml"
using MyProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\_ViewImports.cshtml"
using MyProfile.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\_ViewImports.cshtml"
using MyProfile.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d869add53a4fe53a9950c7975f8327b139bf545f", @"/Views/Admin/RegistrationConfirmationPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eceec0405fca9a60055a0b3042e6e4755c0138", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegistrationConfirmationPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\RegistrationConfirmationPage.cshtml"
  
    ViewBag.Title = "Registration Confirmation Page";
    Layout = "_Layout.cshtml";

    var link = "";
    var username = "";
    if (!string.IsNullOrWhiteSpace(ViewBag.Link))
    {
        link = ViewBag.Link;
    }
    if (!string.IsNullOrWhiteSpace(ViewBag.UserName))
    {
        username = ViewBag.UserName;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex justify-content-center mt-5\" style=\"height:70vh\">\r\n\r\n    <div class=\"border col-4 rounded p-4\" style=\"min-height:300px\">\r\n        <h1 class=\"mb-3\">Welcome ");
#nullable restore
#line 21 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\RegistrationConfirmationPage.cshtml"
                            Write(username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>Your account has been successfully created</p>\r\n        <p>click the link below to activate your account  </p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 681, 1);
#nullable restore
#line 24 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\RegistrationConfirmationPage.cshtml"
WriteAttributeValue("", 676, link, 676, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Activate Account</a>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
