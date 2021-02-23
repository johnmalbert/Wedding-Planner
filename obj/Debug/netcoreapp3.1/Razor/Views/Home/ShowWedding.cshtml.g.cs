#pragma checksum "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57b815922114c5e8b34a25634877450c92de106d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowWedding), @"mvc.1.0.view", @"/Views/Home/ShowWedding.cshtml")]
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
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b815922114c5e8b34a25634877450c92de106d", @"/Views/Home/ShowWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/wedding.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Wedding Flowers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 25%; margin: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
  
    ViewData["Title"] = "Weddings Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
                     Write(Model.Groom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 6 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
                                      Write(Model.Bride);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "57b815922114c5e8b34a25634877450c92de106d5078", async() => {
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
            WriteLiteral("</h1>\r\n    <h4>Date: ");
#nullable restore
#line 7 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
         Write(Model.WeddingDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Address: ");
#nullable restore
#line 8 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"row\">\r\n        <div class=\"col border\">\r\n        <h4>Guests:</h4>\r\n            <ul>\r\n");
#nullable restore
#line 13 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
                 foreach (var item in @Model.RSVPs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><h4>");
#nullable restore
#line 15 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
                       Write(item.UserRSVPd.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></li>\r\n");
#nullable restore
#line 16 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col\">\r\n            <div class=\"col p-5\">\r\n                <iframe width=\"100%\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
            BeginWriteAttribute("src", "\r\n                    src=\"", 764, "\"", 918, 5);
            WriteAttributeValue("", 791, "https://www.google.com/maps/embed/v1/directions?origin=", 791, 55, true);
#nullable restore
#line 22 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
WriteAttributeValue("", 846, ViewBag.CurrentUser.Address, 846, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 874, "&destination=", 874, 13, true);
#nullable restore
#line 22 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\WeddingPlanner\Views\Home\ShowWedding.cshtml"
WriteAttributeValue("", 887, Model.Address, 887, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 901, "&key={YourAPIKey}", 901, 17, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                    allowfullscreen>\r\n                </iframe>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
