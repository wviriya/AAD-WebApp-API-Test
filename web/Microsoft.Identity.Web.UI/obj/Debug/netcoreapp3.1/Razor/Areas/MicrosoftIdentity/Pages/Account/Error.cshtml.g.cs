#pragma checksum "C:\Dev\aad-webapp-api-test\web\Microsoft.Identity.Web.UI\Areas\MicrosoftIdentity\Pages\Account\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebae903ffa45a9175f6cb9933c2c390e65e0b619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MicrosoftIdentity_Pages_Account_Error), @"mvc.1.0.razor-page", @"/Areas/MicrosoftIdentity/Pages/Account/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebae903ffa45a9175f6cb9933c2c390e65e0b619", @"/Areas/MicrosoftIdentity/Pages/Account/Error.cshtml")]
    public class Areas_MicrosoftIdentity_Pages_Account_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Dev\aad-webapp-api-test\web\Microsoft.Identity.Web.UI\Areas\MicrosoftIdentity\Pages\Account\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Dev\aad-webapp-api-test\web\Microsoft.Identity.Web.UI\Areas\MicrosoftIdentity\Pages\Account\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "C:\Dev\aad-webapp-api-test\web\Microsoft.Identity.Web.UI\Areas\MicrosoftIdentity\Pages\Account\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Dev\aad-webapp-api-test\web\Microsoft.Identity.Web.UI\Areas\MicrosoftIdentity\Pages\Account\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microsoft.Identity.Web.UI.Areas.MicrosoftIdentity.Pages.Account.ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Microsoft.Identity.Web.UI.Areas.MicrosoftIdentity.Pages.Account.ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Microsoft.Identity.Web.UI.Areas.MicrosoftIdentity.Pages.Account.ErrorModel>)PageContext?.ViewData;
        public Microsoft.Identity.Web.UI.Areas.MicrosoftIdentity.Pages.Account.ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
