#pragma checksum "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\About\Accessibility.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "371f06d4ed014006a9f12b7ffce85cc905d41d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Accessibility), @"mvc.1.0.view", @"/Views/About/Accessibility.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371f06d4ed014006a9f12b7ffce85cc905d41d03", @"/Views/About/Accessibility.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5513d283e348f351891d376a5c38fb0e39b676c3", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Accessibility : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\ACER\source\repos\C#\GameStop\GameStop\Views\About\Accessibility.cshtml"
  
    ViewData["Title"] = "Accessibility";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "371f06d4ed014006a9f12b7ffce85cc905d41d035164", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Accessibility | GameStop</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "371f06d4ed014006a9f12b7ffce85cc905d41d035642", async() => {
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



<div class=""accessContent"">
    <div class=""content-accessibility"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""allAccessibility col-lg-12"">
                    <div class=""accessMain"">
                        <div id=""mainAccess"" class=""access__header_top"">
                            <h1>Accessibility Statement</h1>
                            <p>This Accessibility Statement applies to GameStop</p>
                        </div>
                    </div>
                    <div class=""accessMain"">
                        <div class=""access__img"">
                            <img src=""https://media.gamestop.com/i/gamestop/AudioEye_AccessibilityStatement_ADA-evolution"" alt=""Accessibility logos"" class=""img-large"">
                        </div>
                    </div>

                    <div class=""accessMain"">
                        <div class=""access__header_top"">
                            <h2>We Value Digital Inclusion</h2>

                 ");
            WriteLiteral(@"       </div>

                        <div class=""access__desc"">
                            <p>In our effort to provide a fully accessible and optimized user experience for all site visitors, GameStop has taken careful measure to ensure an excellent user experience, regardless of the assistive technology being used to access this site or the specific abilities of those individuals seeking access to this site.</p>
                            <p>GameStop website is monitored and tested regularly by internal resources and by AudioEye, a third-party provider of Web Accessibility testing and monitoring. As issues of accessibility are identified, results of automated and manual testing are managed through the AudioEye® Digital Accessibility Platform. As new solutions are discovered to improve the user experience, remediation is tracked through the AudioEye system and fixes are implemented to improve the website user experience.</p>
                        </div>
                    </div>

                    <di");
            WriteLiteral(@"v class=""accessMain"">
                        <div class=""access__header_top"">
                            <h2>AudioEye Accessibility Certification</h2>

                        </div>

                        <div class=""access__desc"">
                            <p>The AudioEye Certification seal represents a commitment to accessibility and digital inclusion. The AudioEye certification process involves automatic and manual testing with the goal of maximizing conformance with Web Content Accessibility Guidelines (WCAG) 2.0 Level AA Success Criteria.</p>
                            <p>
                                AudioEye and GameStop continue to collaborate in an ongoing effort to maintain conformance and provide an accessible user experience for all users.
                            </p>
                        </div>
                    </div>

                    <div class=""accessMain"">
                        <div class=""access__header_top"">
                        </div>

                        <");
            WriteLiteral(@"div class=""access__desc"">
                            <p>
                                This website is regularly tested using a variety of assistive technologies. We recommend using the following web browser / screen reader combinations for an optimized experience:

                            </p>
                            <p>
                                For Windows users: JAWS and Internet Explorer or NVDA and Firefox
                            </p>
                            <p>
                                For Mac users: VoiceOver and Safari or VoiceOver and Chrome
                            </p>
                            <p>
                                For mobile users: VoiceOver for the iPhone and TalkBack for Android devices
                            </p>
                        </div>
                    </div>

                    <div class=""accessMain"">
                        <div class=""access__header_top"">
                            <h2>Third-Party Services</h2>
         ");
            WriteLiteral(@"               </div>

                        <div class=""access__desc"">
                            <p>
                                Throughout this website, we make use of different third-party websites such as Instagram, YouTube, Twitter, and Facebook to spread news and information about GameStop products and services. These sites, which are not controlled by GameStop, may present challenges for individuals with disabilities that we are not able to control or remedy.
                            </p>
                            <p>
                                As made publicly available, here are the Accessibility Policies provided from these third-party sites:
                            </p>
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
