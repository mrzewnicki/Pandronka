#pragma checksum "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3989973347fe8b2d8730f43d7a70895892599932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\_ViewImports.cshtml"
using Pandronka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\_ViewImports.cshtml"
using Pandronka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3989973347fe8b2d8730f43d7a70895892599932", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f62ad8885829f3037726fa655ad10669603e095", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pandronka.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />


<br /><br />

      <div class=""backgroundWhite container"">
         
          <ul id=""menu-filters"" class=""menu-filter-list list-inline text-center"">
              <li class=""active btn btn-secondary ml-1 mr-1"" data-filter="".menu-restaurant"">Pokaz wszystkie</li>

");
#nullable restore
#line 13 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
               foreach (var item in Model.Category)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 15 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
                                                 Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 15 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </ul>\n\n\n");
#nullable restore
#line 20 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
           foreach(var category in Model.Category)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"row\" id=\"menu-wrapper\">\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3989973347fe8b2d8730f43d7a708958925999325430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 23 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n              </div>\n");
#nullable restore
#line 25 "C:\Users\Rafik\Desktop\pandronaNew\Pandronka\Pandronka\Pandronka\Areas\Customer\Views\Home\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
      <script src=""https://code.jquery.com/jquery-3.3.1.js""
              integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
              crossorigin=""anonymous""></script>

<script>

    var posts = $('.post');

    (function ($) {

        $(""#menu-filters li"").click(function () {
            $(""#menu-filters li"").removeClass('active btn btn-secondary');
            $(this).addClass('active btn btn-secondary');

            var selectedFilter = $(this).data(""filter"");

            $("".menu-restaurant"").fadeOut();

            setTimeout(function () {
                $(selectedFilter).slideDown();
            }, 300);
        });



    })(jQuery);
 
</script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pandronka.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
