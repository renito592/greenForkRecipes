#pragma checksum "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4be37b8960184d5b8eae2d5f66e0d2de700d6b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_List), @"mvc.1.0.view", @"/Views/Recipe/List.cshtml")]
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
#line 1 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\_ViewImports.cshtml"
using GreenForkRecipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\_ViewImports.cshtml"
using GreenForkRecipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4be37b8960184d5b8eae2d5f66e0d2de700d6b1", @"/Views/Recipe/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6247e7b025986369cfa75d3910c66b63c3cec62d", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GreenForkRecipes.ViewModels.Recipes.RecipeVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
  
    ViewData["Title"] = "Recipes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4be37b8960184d5b8eae2d5f66e0d2de700d6b14831", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"grid-container\" >       \r\n");
#nullable restore
#line 13 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
         foreach (var item in Model)
        {            

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 16 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
         if (item.Picture == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img src=\"https://static.vecteezy.com/system/resources/thumbnails/000/086/431/small/free-vector-paper-plate.jpg\" alt=\"profile-pic\"  />\r\n");
#nullable restore
#line 19 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4be37b8960184d5b8eae2d5f66e0d2de700d6b17017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 608, "~/images/", 608, 9, true);
#nullable restore
#line 22 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
AddHtmlAttributeValue("", 617, item.Picture, 617, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 26 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">by: ");
#nullable restore
#line 27 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
                                 Write(" " + item.User.FirstName + " " + item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 28 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
             if (GreenForkRecipes.Services.AuthenticationService.LoggedUser.Id == item.UserId)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> |</span>\r\n");
#nullable restore
#line 32 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
                                                                          ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>           \r\n");
#nullable restore
#line 37 "D:\Online edu 2\6 - S-programming\GreenForkRecipes\GreenForkRecipes\Views\Recipe\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GreenForkRecipes.ViewModels.Recipes.RecipeVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
