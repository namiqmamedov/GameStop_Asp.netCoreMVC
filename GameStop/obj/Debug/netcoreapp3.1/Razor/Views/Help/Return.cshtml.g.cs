#pragma checksum "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Help\Return.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9dac0f3e8c32b66c653eb207b81e9544418f42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Help_Return), @"mvc.1.0.view", @"/Views/Help/Return.cshtml")]
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
#nullable restore
#line 8 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ViewModels.CategoryMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ViewModels.UserVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\_ViewImports.cshtml"
using GameStop.Areas.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9dac0f3e8c32b66c653eb207b81e9544418f42", @"/Views/Help/Return.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b3ff10296c128e7df67fae4ef408488d657088", @"/Views/_ViewImports.cshtml")]
    public class Views_Help_Return : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/style/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Help\Return.cshtml"
  
    ViewData["Title"] = "Return";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9dac0f3e8c32b66c653eb207b81e9544418f425670", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Return Easy | GameStop</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af9dac0f3e8c32b66c653eb207b81e9544418f426146", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css"">
    <link rel=”stylesheet” href=”https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css” />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css""
          integrity=""sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.3/font/bootstrap-icons.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.9.0/slick-theme.min.css""
          integrity=""sha512-17EgCFERpgZKcm0j0fEq1YCJuyAWdz9KUtv1EjVuaOz8pDnh/0nZxmU6BBXwaaxqoi9PQXnRWqlcDB027hgv9A==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.9.0/slick");
                WriteLiteral(@".min.css""
          integrity=""sha512-yHknP1/AwR+yx26cB1y0cjvQUMvEa2PFzt1c9LlS4pRQ5NOTZFWbhBig+X9G9eYW/8m0/4OXNx8pxJ6z57x0dw==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@500&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans&display=swap"" rel=""stylesheet"">
    <link rel=""icon"" href=""https://www.gamestop.com/on/demandware.static/Sites-gamestop-us-Site/-/default/dwfa874e29/images/favicons/favicon.ico"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""return-center"">
    <div class=""return-section"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""allReturn col-lg-12"">
                    <div class=""returnAll"">
                        <div class=""topHeader"">
                            Return Policy
                        </div>
                        <div class=""returnMain"">
                            <div class=""returnHeader"">
                                <div>Returns & Exchanges</div>
                            </div>

                            <div class=""returnText"">

                                <div class=""info-r"">
                                    1. Please contact Customer Service on our site, indicating the item(s) you would like to return and the reason.
                                </div>
                                <div class=""info-r"">
                                    2. After receiving return instructions from us, please package up the item(s) to be returne");
            WriteLiteral(@"d with the original packing.
                                </div>
                                <div class=""info-r"">
                                    3. Drop off your package at the local post office.
                                </div>
                                <div class=""info-r"">
                                    4. Most returns are processed within 5 business days after we receive your package. We'll issue the refund to your GameStop wallet if we are not otherwise informed to refund to your payment account in advance. Wallet balance can be used on your next purchase or be withdrawn to your payment account. Once your refund has been issued, you will receive a confirmation email.
                                </div>
                            </div>
                        </div>
                        <div class=""returnMain"">
                            <div class=""returnHeader"">
                                <div>Return Conditions</div>
                            </div>

         ");
            WriteLiteral(@"                   <div class=""returnText"">
                                <div class=""info-r"">
                                    1. You have 30 days to decide if an item is right for you, if you would like to return or exchange the item please contact us within 30 days of delivery.
                                </div>
                                <div class=""info-r"">
                                    2. The following items cannot be returned or exchanged: bodysuits, lingerie, swimwear, jewelry, underwear, event & party supplies, DIY supplies, pet supplies, beauty and accessories (except scarves, bags, and mermaid blankets).

                                </div>
                                <div class=""info-r"">
                                    3. Returned items must be in their unused condition with the original packing. We do not accept a returned item that has been worn, damaged, washed, or altered in any way.
                                </div>
                                <div clas");
            WriteLiteral(@"s=""info-r"">
                                    4. Items with non-returnable marks and free gifts cannot be returned.
                                </div>
                                <div class=""info-r"">
                                    5. We do not accept returned items that have been sent back without proper returns requests.
                                </div>
                                <div class=""info-r"">
                                    6. We do not offer Freight To Collect (FTC) service for the packages returned to us. The returns will be made at your own cost.
                                </div>
                                <div class=""info-r"">
                                    7. Please be sure to double-check your returns before shipping them out. We are not responsible for the return of non-SHEIN products .
                                </div>
                            </div>
                        </div>
                        <div class=""returnMain"">
            ");
            WriteLiteral(@"                <div class=""returnHeader"">
                                <div>Return Address</div>
                            </div>

                            <div class=""returnText"">
                                <div class=""info-r"">
                                    Please contact our Customer Service if you wish to return any items to the nearest return address. You will receive a response as soon as possible.
                                    Note: Please do not send your return to the address on your package. That is not our return address and will affect the processing of your return.
                                    NOTE: If there is an issue with your return, please contact Customer Support within 180 days from the date your order was placed.
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
