#pragma checksum "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Shared\_ProductSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e215663c682643fdd23b11497c057b4f273ee32f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSearchPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductSearchPartial.cshtml")]
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
#line 2 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ComponentViewModels.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ViewModels.Basket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e215663c682643fdd23b11497c057b4f273ee32f", @"/Views/Shared/_ProductSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b0afde71a3da77e3a524c1af222316d18c29508", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Shared\_ProductSearchPartial.cshtml"
 foreach (Product product in Model.Take(10))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"item-pr\">\r\n        <a href=\"#\">\r\n            <span class=\"search__text\">\r\n                <span>");
#nullable restore
#line 9 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Shared\_ProductSearchPartial.cshtml"
                 Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </span>\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Shared\_ProductSearchPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
