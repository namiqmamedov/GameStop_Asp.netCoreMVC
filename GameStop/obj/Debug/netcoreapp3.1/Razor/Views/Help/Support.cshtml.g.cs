#pragma checksum "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Help\Support.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c20e437f70df906f801b8df3c76c807459a7940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Help_Support), @"mvc.1.0.view", @"/Views/Help/Support.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c20e437f70df906f801b8df3c76c807459a7940", @"/Views/Help/Support.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24206e29f676ee0ab0c1c366a48ee4aff5fa04b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Help_Support : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\Help\Support.cshtml"
  
    ViewData["Title"] = "Support";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c20e437f70df906f801b8df3c76c807459a79405122", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>24/7 Support | GameStop</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c20e437f70df906f801b8df3c76c807459a79405609", async() => {
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
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1");
                WriteLiteral(@".9.0/slick.min.css""
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
                            24/7 Customer Service
                        </div>
                        <div class=""returnMain"">
                            <div class=""returnHeader"">
                                <div>Improve Customer Satisfaction</div>
                            </div>

                            <div class=""returnText"">

                                <div class=""info-r"">
                                    Your customers are spread throughout the country – or even globally – and they all have different schedules and may contact your company at different times for support. On top of that they all have their own preferred channels for communicating.
                                </div>
      ");
            WriteLiteral(@"                          <div class=""info-r"">
                                    Simply having a part-time team of customer service representatives, or only opening up your phone, website chat or email during a certain time of day could pose issues for those without typical 9-5 schedules. When your customers are having issues, you want to know about it as soon as possible.
                                </div>
                                <div class=""info-r"">
                                    24/7 customer service and returns support is a key way to enhance customer satisfaction. No matter what time – day or night – a customer can initiate a return, or discuss an issue they’re having with your product or services, so that the appropriate action can be taken. This availability makes it easier to provide great customer service experiences – and ensures your customers always feel like their needs are being met.
                                </div>
                                <div class=""info-");
            WriteLiteral(@"r"">
                                    4. Most returns are processed within 5 business days after we receive your package. We'll issue the refund to your GameStop wallet if we are not otherwise informed to refund to your payment account in advance. Wallet balance can be used on your next purchase or be withdrawn to your payment account. Once your refund has been issued, you will receive a confirmation email.
                                </div>
                            </div>
                        </div>
                        <div class=""returnMain"">
                            <div class=""returnHeader"">
                                <div>Streamline The Return Process</div>
                            </div>

                            <div class=""returnText"">
                                <div class=""info-r"">
                                    Your goal should always be to minimize the time it takes for a customer to make a return. The sooner they send their items back, the sooner");
            WriteLiteral(@" you can process their refunds, and the sooner you can restock the returned product, to resell it to someone else. The longer it takes for a customer to return an item, the longer each of these processes will take.
                                </div>
                            </div>
                        </div>
                        <div class=""returnMain"">
                            <div class=""returnHeader"">
                                <div>Enhance Brand Loyalty & Recognition</div>
                            </div>

                            <div class=""returnText"">
                                <div class=""info-r"">
                                    Every company should make it their goal to be known for stellar customer service. Many successful businesses have built their entire brands on offering great, reliable, and always-available service.
                                </div>
                                <div class=""info-r"">
                                    Gr");
            WriteLiteral(@"eat service helps businesses build better brand reputations, and fosters loyalty with existing customers.
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
