#pragma checksum "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85158a9f152fe6118040f82a8e763bf92f559a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MagillStore.WebSite.Pages.Pages_Laptops), @"mvc.1.0.razor-page", @"/Pages/Laptops.cshtml")]
namespace MagillStore.WebSite.Pages
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
#line 1 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\_ViewImports.cshtml"
using MagillStore.WebSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85158a9f152fe6118040f82a8e763bf92f559a3c", @"/Pages/Laptops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132f2481cd826be63e39cf22c88f3bfcafcad3f2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Laptops : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("border", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/store.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:900px;height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\"><b>Laptops</b></h1>\r\n\r\n    <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85158a9f152fe6118040f82a8e763bf92f559a3c4088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n\r\n</div>\r\n<br />\r\n\r\n<!-- this uses the SQLite database and IEnumerable<Product> interface to display  products -->\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 15 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <b>Product:</b> ");
#nullable restore
#line 20 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p></p>\r\n                    <b>Brand:</b> ");
#nullable restore
#line 21 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
                             Write(product.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p></p>\r\n                    <b>Description:</b> ");
#nullable restore
#line 22 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
                                   Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p></p>\r\n                    <b>Type:</b> ");
#nullable restore
#line 23 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
                            Write(product.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p></p>\r\n                    <b>Price</b> =$");
#nullable restore
#line 24 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
                              Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p></p>\r\n                    <button>Add to cart</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\happy\source\repos\MagillStore\MagillStore.WebSite\Pages\Laptops.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MagillStore.WebSite.Pages.LaptopsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MagillStore.WebSite.Pages.LaptopsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MagillStore.WebSite.Pages.LaptopsModel>)PageContext?.ViewData;
        public MagillStore.WebSite.Pages.LaptopsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
