#pragma checksum "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f7e7619dd0593fe8e813022422fc558f61001c31a89a3711d8361697333e2d15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_AnnouncementDetails), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/AnnouncementDetails.cshtml")]
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
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f7e7619dd0593fe8e813022422fc558f61001c31a89a3711d8361697333e2d15", @"/Areas/Writer/Views/Default/AnnouncementDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_AnnouncementDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Announcement>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
  
    ViewData["Title"] = "AnnouncementDetails";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e7619dd0593fe8e813022422fc558f61001c31a89a3711d8361697333e2d153963", async() => {
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 10 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
     Html.Label("MESAJ DETAYLARI")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <br />\r\n    ");
                Write(
#nullable restore
#line 14 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
     Html.Label("ID")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 15 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
     Html.TextBoxFor(x => x.Id, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    <br />\r\n    ");
                Write(
#nullable restore
#line 17 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
     Html.Label("İçerik")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 18 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Areas\Writer\Views\Default\AnnouncementDetails.cshtml"
     Html.TextAreaFor(x => x.Content, 10, 3, new {@class = "form-control"})

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Announcement> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
