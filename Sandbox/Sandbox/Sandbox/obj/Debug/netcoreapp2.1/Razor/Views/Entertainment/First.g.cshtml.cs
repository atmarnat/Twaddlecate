#pragma checksum "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Entertainment\First.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e082c53f0709ec4d720108bf616456bf7f43c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entertainment_First), @"mvc.1.0.view", @"/Views/Entertainment/First.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Entertainment/First.cshtml", typeof(AspNetCore.Views_Entertainment_First))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e082c53f0709ec4d720108bf616456bf7f43c44", @"/Views/Entertainment/First.cshtml")]
    public class Views_Entertainment_First : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imageAvatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pictures/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\wwstudent\source\repos\TwaddleCate\Sandbox\Sandbox\Sandbox\Views\Entertainment\First.cshtml"
  
    ViewBag.Title = "Entertainment";
    Layout = "~/Views/Shared/_DiscussionLayout.cshtml";

#line default
#line hidden
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("pageName", async() => {
                BeginContext(124, 45, true);
                WriteLiteral("\r\n    <h1 align=\"center\">Entertainment</h1>\r\n");
                EndContext();
            }
            );
            BeginContext(172, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(176, 3035, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc967720d6ed41b59d88d5579c732eec", async() => {
                BeginContext(182, 72, true);
                WriteLiteral("\r\n    <div class=\"divFirst\">\r\n        <div class=\"divImg\">\r\n            ");
                EndContext();
                BeginContext(254, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2618f79e0344016a863b6dd03acaeac", async() => {
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
                EndContext();
                BeginContext(309, 578, true);
                WriteLiteral(@"
        </div>
        <div class=""divWrapper"">
            <table style=""width:100%"">
                <tr>
                    <td class=""tdCheck""><input type=""checkbox"" name=""#"" value=""#"" checked><br></td>
                    <th class=""tdOther"">[Anonymous] [date/time] [1]</th>
                </tr>
                <tr>
                    <td></td>
                    <td class=""tdOther"">First! </td>
                </tr>
            </table>
        </div>
    </div>

    <br />

    <div class=""divReply"">
        <div class=""divImg"">
            ");
                EndContext();
                BeginContext(887, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30b2b53c4948415eaa024438e4e21ada", async() => {
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
                EndContext();
                BeginContext(942, 1676, true);
                WriteLiteral(@"
        </div>
        <div class=""divWrapper"">
            <table style=""width:100%"">
                <tr>
                    <td class=""tdCheck""><input type=""checkbox"" name=""#"" value=""#"" checked><br></td>
                    <th class=""tdOther"">[Anonymous] [date/time] [2] :: <a href=""#"" name=""replyLink"">~3</a></th>
                </tr>
                <tr>
                    <td></td>
                    <td class=""tdOther"">This is the second post of the discussion. Notice the different color of the background and added border. I have made this message intentionally long in order to text how the scaling is done on the table that houses these elements. World of Warcraft is a time vampire that keeps trying to bite me. I have avoided it so far. I will copy paste this 2 times. This is the second post of the discussion. Notice the different color of the background and added border. I have made this message intentionally long in order to text how the scaling is done on the table that houses these el");
                WriteLiteral(@"ements. World of Warcraft is a time vampire that keeps trying to bite me. I have avoided it so far. I will copy paste this 2 times. This is the second post of the discussion. Notice the different color of the background and added border. I have made this message intentionally long in order to text how the scaling is done on the table that houses these elements. World of Warcraft is a time vampire that keeps trying to bite me. I have avoided it so far. I will copy paste this 2 times. </td>
                </tr>
            </table>
        </div>
    </div>

    <br />
    <div class=""divReply"">
        <div class=""divImg"">
            ");
                EndContext();
                BeginContext(2618, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0e6dc1fe663402f944080cee30bc446", async() => {
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
                EndContext();
                BeginContext(2673, 531, true);
                WriteLiteral(@"
        </div>
        <div class=""divWrapper"">
            <table style=""width:100%"">
                <tr>
                    <td class=""tdCheck""><input type=""checkbox"" name=""#"" value=""#"" checked><br></td>
                    <th class=""tdOther"">[Anonymous] [date/time] [3]</th>
                </tr>
                <tr>
                    <td></td>
                    <td class=""tdOther""><a href=""#"" name=""replyLink"">~2</a> <br />lol </td>
                </tr>
            </table>
        </div>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(3211, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
