#pragma checksum "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0060b78406e65a519c4e29bd32a2041fa33fc15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AccountConfirmation), @"mvc.1.0.view", @"/Views/Admin/AccountConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0060b78406e65a519c4e29bd32a2041fa33fc15d", @"/Views/Admin/AccountConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eceec0405fca9a60055a0b3042e6e4755c0138", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AccountConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
  
    ViewBag.Title = "Registration success Page";
    Layout = "_Layout.cshtml";

    var username = "";
    if(!string.IsNullOrWhiteSpace(ViewBag.UserName))
    {
        username = ViewBag.UserName;
    }

    var errMsg = "";
    if (!string.IsNullOrWhiteSpace(ViewBag.ErrorMessage))
    {
        errMsg = ViewBag.ErrorMessage;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex justify-content-center mt-5\" style=\"height:70vh\">\r\n\r\n    <div class=\"border col-4 rounded p-4\" style=\"min-height:300px\">\r\n");
#nullable restore
#line 22 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
         if (errMsg != "")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
       Write(errMsg);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
                   
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"mb-3\">Welcome ");
#nullable restore
#line 28 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
                                Write(username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>Account successfully creates</p>\r\n");
#nullable restore
#line 30 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Admin\AccountConfirmation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
