#pragma checksum "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1bfbffe2b02e217af0d5bc9e028540e9a8e56be34457750e8b1eed0f62184c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1bfbffe2b02e217af0d5bc9e028540e9a8e56be34457750e8b1eed0f62184c50", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61d9d5c47f96e4e1247ef195cf0d9d15902dd2d7331cb8895471cf3cdc81bde1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">   
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Proje Adı</th>
                                <th> URL </th>
                                <th> Fiyat</th>
                                <th> Görsel</th>
                                <th> Tamamlanma</th>
                                <th> Detaylar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 23 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td> ");
            Write(
#nullable restore
#line 26 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.PortfolioID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 27 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 28 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.ProjectUrl

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 29 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td> <img");
            BeginWriteAttribute("src", " src=\"", 1266, "\"", 1286, 1);
            WriteAttributeValue("", 1272, 
#nullable restore
#line 30 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                    item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1272, 14, false);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 31 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.Value

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1441, "\"", 1490, 2);
            WriteAttributeValue("", 1448, "/Portfolio/EditPortfolio/", 1448, 25, true);
            WriteAttributeValue("", 1473, 
#nullable restore
#line 33 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                                           item.PortfolioID

#line default
#line hidden
#nullable disable
            , 1473, 17, false);
            EndWriteAttribute();
            WriteLiteral("><div class=\"badge badge-outline-info\">Detayları Gör</div></a>\r\n                                    </td> \r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\İBRAHİM\Desktop\c# projeler\Core_ilk_Proje\Core_ilk_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
