#pragma checksum "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f6faafeb5a02b01e301bfa00bc604bf2b028a26fa6fe3c9792122875490b4bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
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

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f6faafeb5a02b01e301bfa00bc604bf2b028a26fa6fe3c9792122875490b4bfd", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61d9d5c47f96e4e1247ef195cf0d9d15902dd2d7331cb8895471cf3cdc81bde1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ExperienceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"experience\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Deneyimler</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                <div class=""col-md-6"">

                    <div class=""card mb-3"" data-aos=""fade-right"" data-aos-delay=""100"">
                        <div class=""card-header px-3 py-2"">
                            <div class=""d-flex justify-content-between"">
                                <div>
                                    <h3 class=""h5 mb-1"">");
            Write(
#nullable restore
#line 18 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h3>\r\n                                    <div class=\"text-muted text-small\">");
            Write(
#nullable restore
#line 19 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                                        item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                                </div><img");
            BeginWriteAttribute("src", " src=\"", 859, "\"", 879, 1);
            WriteAttributeValue("", 865, 
#nullable restore
#line 20 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                 item.ImageUrl

#line default
#line hidden
#nullable disable
            , 865, 14, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"ui-ux\" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-body px-3 py-2\">\r\n                            <p>");
            Write(
#nullable restore
#line 24 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                                item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
