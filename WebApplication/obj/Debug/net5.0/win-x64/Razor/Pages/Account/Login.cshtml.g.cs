#pragma checksum "D:\ASP.NET\WebApplication\WebApplication\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f56ad6efc8daa086a1ddea328417593ca1ed31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Account_Login), @"mvc.1.0.view", @"/Pages/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f56ad6efc8daa086a1ddea328417593ca1ed31", @"/Pages/Account/Login.cshtml")]
    public class Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h1>Вход в личный кабинет</h1>\r\n    <div>\r\n        <form asp-area=\"Admin\" asp-controller=\"Account\" asp-action=\"Login\" method=\"post\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 189, "\"", 229, 1);
#nullable restore
#line 6 "D:\ASP.NET\WebApplication\WebApplication\Pages\Account\Login.cshtml"
WriteAttributeValue("", 211, ViewBag.returnUrl, 211, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div asp-validator-summary=""All""></div>
            <div>
                <label asp-for=""UserName""></label>
                <input asp-for=""UserName""/>
                <span asp-validator-for=""UserName""></span>
            </div>
            <div>
                <label asp-for=""Password""></label>
                <input asp-for=""Password""/>
                <span asp-validator-for=""Password""></span>
            </div>
            <div>
                <label asp-for=""RememberMe""></label>
                <input asp-for=""RememberMe""/>
                <span asp-validator-for=""RememberMe""></span>
            </div>
            <div>
                <input type=""submit"" value=""Войти"">
            </div>
        </form>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591