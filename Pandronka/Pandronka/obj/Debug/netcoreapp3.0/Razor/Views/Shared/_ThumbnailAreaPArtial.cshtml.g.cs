#pragma checksum "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5360d60722ad2f85dcc563431e487df48be2ab54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPArtial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
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
#line 1 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\_ViewImports.cshtml"
using Pandronka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\_ViewImports.cshtml"
using Pandronka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5360d60722ad2f85dcc563431e487df48be2ab54", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded87d66aba51b89722e15c71eb4e12e830bddd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPArtial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 183, "\"", 282, 4);
            WriteAttributeValue("", 191, "col-12", 191, 6, true);
            WriteAttributeValue(" ", 197, "post", 198, 5, true);
#nullable restore
#line 8 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue(" ", 202, Model.FirstOrDefault().Category.Name.Replace(" ",string.Empty), 203, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 266, "menu-restaurant", 267, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"row\">\n            <h3 class=\"text-success\"> ");
#nullable restore
#line 10 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                 Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n        </div>\n\n");
#nullable restore
#line 13 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-info rounded col-12\" style=\"margin-bottom:10px; margin-top:10px; padding:10px\">\n                <div class=\"row\">\n                    <div class=\"col-md-3 col-sm-12\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 688, "\"", 705, 1);
#nullable restore
#line 18 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue("", 694, item.Image, 694, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""99%"" style=""border-radius:5px;border:1px solid #bbb9b9"" />
                    </div>
                    <div class=""col-md-9 col-sm-12"">
                        <div class=""row pr-3"">
                            
                            <div class=""col-4 text-right"" style=""color:maroon"">
                                <h4>$");
#nullable restore
#line 24 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            </div>\n                        </div>\n\n\n                        <div class=\"row col-12 text-justify d-none d-md-block\">\n                            <p>");
#nullable restore
#line 30 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                          Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                        <div class=\"col-md-3 col-sm-12 offset-md-9 text-center\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5360d60722ad2f85dcc563431e487df48be2ab547082", async() => {
                WriteLiteral("Szczegoly");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                    </div>\n                </div> \n");
#nullable restore
#line 38 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"p-4\"></div>\n    </div>\n");
#nullable restore
#line 41 "C:\Users\Rafik\Desktop\Pandronka\Pandronka\Views\Shared\_ThumbnailAreaPArtial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591