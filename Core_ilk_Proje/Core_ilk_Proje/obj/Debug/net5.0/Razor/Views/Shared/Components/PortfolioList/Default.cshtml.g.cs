#pragma checksum "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50f59d950aaf804e781cbaf0af2af3c9e3714c97fe86211b2201b0751dbc0d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
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
#line 1 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"50f59d950aaf804e781cbaf0af2af3c9e3714c97fe86211b2201b0751dbc0d99", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61d9d5c47f96e4e1247ef195cf0d9d15902dd2d7331cb8895471cf3cdc81bde1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Portfolio </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 11 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"grid-item\">\r\n                    <a href=\"https://dribbble.com\">\r\n                        <figure class=\"portfolio-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 628, "\"", 648, 1);
            WriteAttributeValue("", 634, 
#nullable restore
#line 16 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                       item.ImageUrl

#line default
#line hidden
#nullable disable
            , 634, 14, false);
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
            Write(
#nullable restore
#line 16 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                                item.ImageUrl2

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\" />\r\n                            <figcaption>\r\n                                <h4 class=\"h5 mb-0\">");
            Write(
#nullable restore
#line 18 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                     item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n                                <div>");
            Write(
#nullable restore
#line 19 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
                                      item.ProjectUrl

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                            </figcaption>\r\n                        </figure>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\PortfolioList\Default.cshtml"
            }   

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
