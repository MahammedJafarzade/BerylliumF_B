#pragma checksum "C:\Users\Mahammed Jafarzade\Desktop\BerylliumF_B\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc11262fca0a7a9132dabe1f6d961f617f3e8c32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc11262fca0a7a9132dabe1f6d961f617f3e8c32", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc11262fca0a7a9132dabe1f6d961f617f3e8c322768", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""./assets/main.css"">
    <title>Beryllium</title>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc11262fca0a7a9132dabe1f6d961f617f3e8c324538", async() => {
                WriteLiteral(@"
    <!-- Start Header area -->
    <div class=""container"">
        <nav class=""navbar navbar-expand-lg bg-light"">
            <div class=""container-fluid"">
                <a class=""navbar-brand"" href=""#"">Beryllium</a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                        data-bs-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false""
                        aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">About</a>
                        </li>
    ");
                WriteLiteral(@"                    <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button""
                               data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Services
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                                <li><a class=""dropdown-item"" href=""#"">Web Design</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Ecommerce</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Branding</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Api</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button""
          ");
                WriteLiteral(@"                     data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Dropdown
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                                <li><a class=""dropdown-item"" href=""#"">Html5</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Css3</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Sass</a></li>
                                <li><a class=""dropdown-item"" href=""#"">JQuery</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Portfolio</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Contact</a>
                        </li>

                    </ul>
                </div>
            </div>
");
                WriteLiteral("        </nav>\r\n        <!-- End Header are -->\r\n        ");
#nullable restore
#line 72 "C:\Users\Mahammed Jafarzade\Desktop\BerylliumF_B\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""footer col-lg-4"">
            <div class=""berry"">
                <h3>Beryllium</h3>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis,
                    rhoncus euismod.
                </p>
            </div>
            <div class=""links"">
                <h3>Links</h3>
                <ul>
                    <li>home</li>
                    <li>features</li>
                    <li>products</li>
                    <li>testimonials</li>
                    <li>contact</li>
                </ul>
            </div>
            <div class=""work"">
                <h3>work</h3>
                <ul>
                    <li>New york arena</li>
                    <li>Eagle park</li>
                    <li>Nationals park</li>
                    <li>manila park</li>
                </ul>
            </div>
            <div class=""forum"">
                <label for=""text"">");
                WriteLiteral(@"
                    <input type=""text"" placeholder=""Email"">
                    <button id=""btn"">
                        Send
                    </button>
                </label>
            </div>

        </div>

    </div>
    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
            crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
