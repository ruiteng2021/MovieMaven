#pragma checksum "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "917f7449d84aa42e396bc453863b6325696da739"
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
#line 1 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\_ViewImports.cshtml"
using MovieMaven;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917f7449d84aa42e396bc453863b6325696da739", @"/Pages/Index.cshtml")]
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
#line 3 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 495, true);
            WriteLiteral(@"
    <div id=""hero-image-wrapper"">
        <iframe id=""static-image"" src=""https://www.youtube.com/embed/HapT0SKcyfY?showinfo=0"" frameborder=""0"" allow=""encrypted-media; picture-in-picture"" allowfullscreen></iframe>
        <!--<iframe id=""static-image"" src=""//www.youtube.com/embed/LuD3_umIxgw?controls=0&loop=1&autoplay=1&showinfo=0&modestbranding=1&disablekb=1&enablejsapi=1&playlist=LuD3_umIxgw"" frameborder=""0""></iframe>-->
    </div>

<div id=""searchDiv"" class=""text-center row"">
    ");
            EndContext();
            BeginContext(566, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21df98d7a25249a68df0985d5faa9e49", async() => {
                BeginContext(651, 144, true);
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
            BeginContext(802, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 19 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
 if (Model.searchTerm != null)
{

#line default
#line hidden
            BeginContext(849, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(853, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ded4b6edf3d454baa34ad815cd474a2", async() => {
                BeginContext(903, 45, true);
                WriteLiteral("\r\n        <input type=\"submit\" name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 948, "\"", 989, 1);
#line 23 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 972, Model.searchTerm, 972, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(990, 9, true);
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
            BeginContext(1006, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1011, 26, true);
            WriteLiteral("\r\n<div id=\"posters\">\r\n    ");
            EndContext();
            BeginContext(1037, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2804159617a9464bb90cde52a70fa721", async() => {
                BeginContext(1084, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
         for (int i = 0; i < Model.posterURLs.Count; i++)
        {
            string path = "https://image.tmdb.org/t/p/w500" +
                Model.posterURLs[i];

#line default
#line hidden
                BeginContext(1257, 31, true);
                WriteLiteral("            <div class=\"thumbs\"");
                EndContext();
                BeginWriteAttribute("style", "\r\n                 style=\"", 1288, "\"", 1360, 6);
                WriteAttributeValue("", 1314, "background:", 1314, 11, true);
                WriteAttributeValue(" ", 1325, "url(", 1326, 5, true);
#line 34 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 1330, path, 1330, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 1335, ");", 1335, 2, true);
                WriteAttributeValue(" ", 1337, "background-size:", 1338, 17, true);
                WriteAttributeValue(" ", 1354, "100%;", 1355, 6, true);
                EndWriteAttribute();
                BeginContext(1361, 67, true);
                WriteLiteral(">\r\n                <input type=\"submit\" class=\"link\" name=\"movieID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 1428, "\"", 1478, 1);
#line 36 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 1460, Model.movieIDs[i], 1460, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1479, 25, true);
                WriteLiteral(" />\r\n            </div>\r\n");
                EndContext();
#line 38 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1515, 4, true);
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
            BeginContext(1526, 31, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div id=\"videos\">\r\n");
            EndContext();
#line 43 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
     if (Model.videoKeys.Count > 0)
    {
        

#line default
#line hidden
#line 45 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
         for (int i = 0; i < Model.MAX_VIDS; i++)
        {
            if (i < Model.videoKeys.Count) // case for less than 3 videos
            {

#line default
#line hidden
            BeginContext(1753, 68, true);
            WriteLiteral("                <iframe class=\"youtubeVids\" width=\"336\" height=\"187\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n                src=\"", 1821, "\"", 1893, 2);
            WriteAttributeValue("", 1844, "https://www.youtube.com/embed/", 1844, 30, true);
#line 50 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
WriteAttributeValue("", 1874, Model.videoKeys[i], 1874, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1894, 175, true);
            WriteLiteral("\r\n                frameborder=\"0\"\r\n                allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\"\r\n                allowfullscreen></iframe>\r\n");
            EndContext();
#line 54 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
            }
        }

#line default
#line hidden
#line 55 "D:\Web\C#Intro\MovieMaven\MovieMaven\Pages\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2102, 6, true);
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
