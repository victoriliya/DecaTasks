#pragma checksum "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Shared\_ProjectList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8088ac508ec551800bc23b47f5d8a00bd53e794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProjectList), @"mvc.1.0.view", @"/Views/Shared/_ProjectList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8088ac508ec551800bc23b47f5d8a00bd53e794", @"/Views/Shared/_ProjectList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31a5a07570cad6b4ea0691ef7ebc7a17bd23e37", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProjectList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<li>");
#nullable restore
#line 4 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Shared\_ProjectList.cshtml"
Write(Model.ProjectLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
