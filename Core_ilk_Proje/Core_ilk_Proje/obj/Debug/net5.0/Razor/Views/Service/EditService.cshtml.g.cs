#pragma checksum "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21fe0024d2a057b7ec64ad61ffb70868467f94cd5b068173a7b6eb73602fb487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_EditService), @"mvc.1.0.view", @"/Views/Service/EditService.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\_ViewImports.cshtml"
using Core_ilk_Proje

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\_ViewImports.cshtml"
using Core_ilk_Proje.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"21fe0024d2a057b7ec64ad61ffb70868467f94cd5b068173a7b6eb73602fb487", @"/Views/Service/EditService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61d9d5c47f96e4e1247ef195cf0d9d15902dd2d7331cb8895471cf3cdc81bde1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_EditService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Service>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
  
    ViewData["Title"] = "EditService";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
 using (Html.BeginForm("EditService", "Service", FormMethod.Post))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">Proje Düzenleme Paneli</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21fe0024d2a057b7ec64ad61ffb70868467f94cd5b068173a7b6eb73602fb4874623", async() => {
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 15 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
                     Html.HiddenFor(x => x.ServiceID)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 17 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
                     Html.Label("Deneyim Başlığı")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 18 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
                     Html.TextBoxFor(x => x.Title, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    <label>Resim Yolu</label>\r\n                    ");
                Write(
#nullable restore
#line 21 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
                     Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-outline-primary\">Güncelle</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 29 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Service\EditService.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
