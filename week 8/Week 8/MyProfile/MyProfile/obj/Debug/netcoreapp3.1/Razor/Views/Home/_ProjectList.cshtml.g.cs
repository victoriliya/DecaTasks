#pragma checksum "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Home\_ProjectList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac6730234e185330d6686bb86c9b8508de725eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProjectList), @"mvc.1.0.view", @"/Views/Home/_ProjectList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac6730234e185330d6686bb86c9b8508de725eb", @"/Views/Home/_ProjectList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eceec0405fca9a60055a0b3042e6e4755c0138", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ProjectList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Home\_ProjectList.cshtml"
  
    var uniqueId = @Model.ProjectName[0] + Model.ProjectId.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<button class=\"btn btn-link underline\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 10 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Home\_ProjectList.cshtml"
                                                                       Write(uniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" aria-expanded=""false"" aria-controls=""collapseOne"">
    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-caret-right"" viewBox=""0 0 16 16"">
        <path d=""M6 12.796V3.204L11.481 8 6 12.796zm.659.753 5.48-4.796a1 1 0 0 0 0-1.506L6.66 2.451C6.011 1.885 5 2.345 5 3.204v9.592a1 1 0 0 0 1.659.753z"" />
    </svg>
    ");
#nullable restore
#line 14 "C:\Users\hp\Desktop\Decagon\Week 8\MyProfile\MyProfile\Views\Home\_ProjectList.cshtml"
Write(Model.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</button>\r\n\r\n");
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
