#pragma checksum "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f78126ae7d9a9311bcc87f9ce7ba35e991827b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieMaven.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MovieMaven.Pages.Pages_Index), null)]
namespace MovieMaven.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\_ViewImports.cshtml"
using MovieMaven;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f78126ae7d9a9311bcc87f9ce7ba35e991827b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5690afd9ee8b7760f61b04f4db0ea1ddec8a712e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "GetPosters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 52, true);
            WriteLiteral("\r\n<div id=\"searchDiv\" class=\"text-center row\">\r\n    ");
            EndContext();
            BeginContext(123, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc4a16b9afda4b86ab32d69c933bb304", async() => {
                BeginContext(220, 144, true);
                WriteLiteral("\r\n        <input class=\"form-control\" type=\"text\" name=\"search\" />\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Search\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(371, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
 if (Model.searchTerm != null)
{

#line default
#line hidden
            BeginContext(418, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(422, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e06b548b584418a8b9061a311aa483e", async() => {
                BeginContext(472, 45, true);
                WriteLiteral("\r\n        <input type=\"submit\" name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 517, "\"", 558, 1);
#line 19 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 541, Model.searchTerm, 541, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(559, 9, true);
                WriteLiteral(" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(575, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(580, 26, true);
            WriteLiteral("\r\n<div id=\"posters\">\r\n    ");
            EndContext();
            BeginContext(606, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ec875728f66422ea9c03a3bfa0b8bb5", async() => {
                BeginContext(653, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
         for (int i = 0; i < Model.posterURLs.Count; i++)
        {
            string path = "https://image.tmdb.org/t/p/w500" +
                Model.posterURLs[i];

#line default
#line hidden
                BeginContext(826, 31, true);
                WriteLiteral("            <div class=\"thumbs\"");
                EndContext();
                BeginWriteAttribute("style", "\r\n                 style=\"", 857, "\"", 929, 6);
                WriteAttributeValue("", 883, "background:", 883, 11, true);
                WriteAttributeValue(" ", 894, "url(", 895, 5, true);
#line 30 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 899, path, 899, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 904, ");", 904, 2, true);
                WriteAttributeValue(" ", 906, "background-size:", 907, 17, true);
                WriteAttributeValue(" ", 923, "100%;", 924, 6, true);
                EndWriteAttribute();
                BeginContext(930, 67, true);
                WriteLiteral(">\r\n                <input type=\"submit\" class=\"link\" name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 997, "\"", 1047, 1);
#line 32 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 1029, Model.movieIDs[i], 1029, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1048, 25, true);
                WriteLiteral(" />\r\n            </div>\r\n");
                EndContext();
#line 34 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1084, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1095, 31, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"videos\">\r\n");
            EndContext();
#line 39 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
     if (Model.videoKeys.Count > 0)
    {
        

#line default
#line hidden
#line 41 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
         for (int i = 0; i < Model.MAX_VIDS; i++)
        {

#line default
#line hidden
            BeginContext(1232, 64, true);
            WriteLiteral("            <iframe class=\"youtubeVids\" width=\"336\" height=\"187\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n            src=\"", 1296, "\"", 1364, 2);
            WriteAttributeValue("", 1315, "https://www.youtube.com/embed/", 1315, 30, true);
#line 44 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 1345, Model.videoKeys[i], 1345, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 114, true);
            WriteLiteral("\r\n            frameborder=\"0\" allow=\"encrypted-media; picture-in-picture\"\r\n            allowfullscreen></iframe>\r\n");
            EndContext();
#line 47 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
        }

#line default
#line hidden
#line 47 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1497, 58, true);
            WriteLiteral("</div>\r\n\r\n<div id=\"movieDetails\" style=\"padding: 25px;\">\r\n");
            EndContext();
#line 52 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
     if (Model.movieRuntime > 0)
    {

#line default
#line hidden
            BeginContext(1596, 21, true);
            WriteLiteral("        <h3>Runtime: ");
            EndContext();
            BeginContext(1618, 29, false);
#line 54 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
                Write(Model.movieRuntime.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1647, 39, true);
            WriteLiteral(" mins</h3>\r\n        <h2>Movie Tagline: ");
            EndContext();
            BeginContext(1687, 18, false);
#line 55 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
                      Write(Model.movieTagline);

#line default
#line hidden
            EndContext();
            BeginContext(1705, 18, true);
            WriteLiteral("</h2>\r\n        <p>");
            EndContext();
            BeginContext(1724, 19, false);
#line 56 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
      Write(Model.movieOverview);

#line default
#line hidden
            EndContext();
            BeginContext(1743, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 57 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1756, 124, true);
            WriteLiteral("</div>\r\n\r\n<div id=\"cast\" style=\"text-align: center;\">\r\n    <!-- use this for the URL: https://image.tmdb.org/t/p/w500/ -->\r\n");
            EndContext();
#line 62 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
     if (Model.castPics.Count > 0)
    {
        

#line default
#line hidden
#line 64 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
         foreach (var pic in Model.castPics)
        {

#line default
#line hidden
            BeginContext(1980, 32, true);
            WriteLiteral("            <div class=\"castPic\"");
            EndContext();
            BeginWriteAttribute("style", " \r\n                 style=\"", 2012, "\"", 2145, 8);
            WriteAttributeValue("", 2039, "background:", 2039, 11, true);
            WriteAttributeValue(" ", 2050, "url(https://image.tmdb.org/t/p/w500/", 2051, 37, true);
#line 67 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 2087, pic, 2087, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2091, ");", 2091, 2, true);
            WriteAttributeValue(" ", 2093, "background-position:", 2094, 21, true);
            WriteAttributeValue(" ", 2114, "center;", 2115, 8, true);
            WriteAttributeValue(" ", 2122, "background-size:", 2123, 17, true);
            WriteAttributeValue(" ", 2139, "100%;", 2140, 6, true);
            EndWriteAttribute();
            BeginContext(2146, 10, true);
            WriteLiteral(" ></div>\r\n");
            EndContext();
#line 68 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
        }

#line default
#line hidden
#line 68 "C:\Users\alien\source\repos\MovieMaven\MovieMaven\Pages\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2174, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
