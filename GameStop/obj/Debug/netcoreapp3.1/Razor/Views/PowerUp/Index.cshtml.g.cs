#pragma checksum "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\PowerUp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e81721b21aec5c14ec5cb585bac05291444551e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PowerUp_Index), @"mvc.1.0.view", @"/Views/PowerUp/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e81721b21aec5c14ec5cb585bac05291444551e8", @"/Views/PowerUp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b3ff10296c128e7df67fae4ef408488d657088", @"/Views/_ViewImports.cshtml")]
    public class Views_PowerUp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\PowerUp\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e81721b21aec5c14ec5cb585bac05291444551e85677", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Become a PowerUp Rewards Member | GameStop</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e81721b21aec5c14ec5cb585bac05291444551e86173", async() => {
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



<div class=""powerUpMain"">
    <div class=""powerup-section"">
        <div class=""topImg"">

            <div class=""mb-img"">
                <img src=""https://media.gamestop.com/i/gamestop/PUR_Hero_Image_768x400.webp"" alt=""PowerUp"">
            </div>
            <div class=""h-img"">
                <img src=""https://media.gamestop.com/i/gamestop/PUR_Hero_Image_1440x600.webp"" alt=""PowerUp"">

            </div>
        </div>

        <div class=""text-container"">
            <span class=""card-title"">Go Pro, Get More</span>
            <span class=""card-sub-title"">More Rewards. More Access. More Everything.</span>
        </div>
    </div>
</div>


<div class=""proItems"">
    <div class=""prop-content"">
        <div class=""pro-center"">
            <p class=""content-title"">Unlock More As A PowerUp Rewards Pro Member</p>
            <p class=""content-sub-title"">Level up your benefits for just $14.99/yr.</p>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col");
            WriteLiteral(@"-12"">
                    <div class=""proItemsCard"">
                        <div class=""pro-items-card"">
                            <div class=""card col-6 col-lg-3 col-md-3"">
                                <img src=""https://media.gamestop.com/i/gamestop/Bonus_Points_Icon_224x224/"" class=""card-img-top"" alt=""1"">
                                <div class=""card-body"">
                                    <h1 class=""card-title"">
                                        Score A $10 Welcome Reward
                                    </h1>
                                    <p class=""card-text"">That’s 10k points that can be used as $10 off the next time you shop. Plus, get 5K points when you renew.</p>
                                </div>
                            </div>
                            <div class=""card col-6 col-lg-3 col-md-3"">
                                <img src=""https://media.gamestop.com/i/gamestop/Coupon_Icon_224x224/"" class=""card-img-top"" alt=""2"">
                                <div cla");
            WriteLiteral(@"ss=""card-body"">
                                    <h1 class=""card-title"">$5 Monthly Reward</h1>
                                    <p class=""card-text"">That's $5 a month ($60 annual) to spend on games, accessories, collectibles, and more. The coupon is added to your account the first week of each month.</p>
                                </div>
                            </div>
                            <div class=""card col-6 col-lg-3 col-md-3"">
                                <img src=""https://media.gamestop.com/i/gamestop/Double_Points_224x224/"" class=""card-img-top"" alt=""3"">
                                <div class=""card-body"">
                                    <h1 class=""card-title"">
                                        Earn 2% Back In Rewards
                                    </h1>
                                    <p class=""card-text"">You'll earn 20 points on every dollar spent.</p>
                                </div>
                            </div>
                            <di");
            WriteLiteral(@"v class=""card col-6 col-lg-3 col-md-3"">
                                <img src=""https://media.gamestop.com/i/gamestop/Early_Access_224x224/"" class=""card-img-top"" alt=""4"">
                                <div class=""card-body"">
                                    <h1 class=""card-title"">Exclusive Early Access</h1>
                                    <p class=""card-text"">Pros get first dibs on new console drops, graphics cards, collectibles, and more.</p>
                                </div>
                            </div>
                            <div class=""card col-6 col-lg-3 col-md-3"">
                                <img src=""https://media.gamestop.com/i/gamestop/Game_Informer_Icon_224x224/"" class=""card-img-top"" alt=""4"">
                                <div class=""card-body"">
                                    <h1 class=""card-title"">Game Informer Subscription</h1>
                                    <p class=""card-text"">The best magazine in the biz is better than ever, and pros enjoy every issue.");
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""powerUpCenter"">
    <div class=""powerup-section-center"">
        <div class=""centerPowerUp"">

            <div class=""leftSection"">
                <div class=""text-details"">
                    <div class=""card-title"">
                        It Pays To Be A Pro
                    </div>
                    <div class=""card-sub-title"">
                        Yes, it really pays. Pros get up to $150 in annual value for just $14.99/year.
                    </div>
                </div>
            </div>

            <div class=""rightSection"">
                <div class=""h-img"">
                    <img src=""https://media.gamestop.com/i/gamestop/Value_Section_632x456_3.webp
            "" alt=""img"">
                </div>
                <div class=""mb-img"">
                    <img src");
            WriteLiteral(@"=""https://media.gamestop.com/i/gamestop/value-section-mobile-v3.webp"" alt=""img"">
                </div>
            </div>
        </div>

    </div>
</div>



<div class=""pro-card-items"">
    <div class=""pro-content"">
        <div class=""header-top"">
            <p class=""header-title"">Pros Get Early Access To New Console Drops</p>
            <p class=""header-sub-title"">On everything from consoles to graphics cards, that’s a mic drop for Pro Members.</p>
        </div>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""proCenterCard"">
                    <div class=""allCard"">
                        <div class=""itemsCard"">
                            <div class=""itemsImg"">
                                <img src=""https://media.gamestop.com/i/gamestop/PS5_390x300"" alt=""ps"">
                            </div>
                            <div class=""itemsText"">
                                <h1 class=""p-card-title"">PlayStation 5</h1>
                             ");
            WriteLiteral(@"   <p class=""p-card-sub-title"">Early access to stock refills of Sony’s PlayStation 5 Consoles.</p>
                            </div>
                        </div>
                        <div class=""itemsCard"">
                            <div class=""itemsImg"">
                                <img src=""https://media.gamestop.com/i/gamestop/Pokemon_Cards_390x300"" alt=""pokemon"">
                            </div>
                            <div class=""itemsText"">
                                <h1 class=""p-card-title"">Trading Cards</h1>
                                <p class=""p-card-sub-title"">Early access to stock refills of Pokémon and other popular trading cards.</p>
                            </div>
                        </div>
                        <div class=""itemsCard"">
                            <div class=""itemsImg"">
                                <img src=""https://media.gamestop.com/i/gamestop/Graphics_Card_390x300"" alt=""gc"">
                            </div>
                            ");
            WriteLiteral(@"<div class=""itemsText"">
                                <h1 class=""p-card-title"">Graphics Cards</h1>
                                <p class=""p-card-sub-title"">Early access to stock refills of PC graphics cards.</p>
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
