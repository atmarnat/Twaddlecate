#pragma checksum "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d0df87306649d0d5b033f92d7cb8d00c314630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models;

#line default
#line hidden
#line 2 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\_ViewImports.cshtml"
using TextForum.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d0df87306649d0d5b033f92d7cb8d00c314630", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649f00815aec7c4e74358276fa613b282ba77f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h1>Admin Index</h1>\r\n<hr />\r\n[");
            EndContext();
            BeginContext(31, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c3146305965", async() => {
                BeginContext(81, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(100, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c3146307546", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("List Roles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(167, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c3146309128", async() => {
                BeginContext(211, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(219, 219, true);
            WriteLiteral("]\r\n<hr />\r\n<h3>Posts List</h3>\r\n<hr />\r\n\r\n<table>\r\n    <tr>\r\n        <th>Picture</th>\r\n        <th>ID</th>\r\n        <th>Topic</th>\r\n        <th>User</th>\r\n        <th>Content</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
     foreach (var post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(485, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 24 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                 if (post.ImgUrl != null)
                {
                    

#line default
#line hidden
#line 26 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                     if (@post.ImgUrl.Contains("webm"))
                    {

#line default
#line hidden
            BeginContext(659, 95, true);
            WriteLiteral("                        <video class=\"thumbnail\" controls>\r\n                            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 754, "\"", 823, 2);
            WriteAttributeValue("", 760, "https://imgrepository.blob.core.windows.net/images/", 760, 51, true);
#line 29 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 811, post.ImgUrl, 811, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(824, 57, true);
            WriteLiteral(" type=\"video/webm\" />\r\n                        </video>\r\n");
            EndContext();
#line 31 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(953, 46, true);
            WriteLiteral("                        <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 999, "\"", 1068, 2);
            WriteAttributeValue("", 1005, "https://imgrepository.blob.core.windows.net/images/", 1005, 51, true);
#line 34 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1056, post.ImgUrl, 1056, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1069, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 35 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#line 35 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1114, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(1150, 11, false);
#line 38 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1185, 12, false);
#line 39 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.TopicID);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1221, 13, false);
#line 40 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1258, 12, false);
#line 41 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1311, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c31463015344", async() => {
                BeginContext(1352, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1408, "\"", 1428, 1);
#line 44 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1416, post.PostID, 1416, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1429, 88, true);
                WriteLiteral(" /><button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1524, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1567, 224, true);
            WriteLiteral("</table>\r\n<hr />\r\n<h3>Reply List</h3>\r\n<hr />\r\n<table>\r\n    <tr>\r\n        <th>Picture</th>\r\n        <th>ID</th>\r\n        <th>Topic</th>\r\n        <th>User</th>\r\n        <th>Content</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 63 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
     foreach (var post in Model.Replies)
    {

#line default
#line hidden
            BeginContext(1840, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 67 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                 if (post.ImgUrl != null)
                {
                    

#line default
#line hidden
#line 69 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                     if (@post.ImgUrl.Contains("webm"))
                    {

#line default
#line hidden
            BeginContext(2014, 95, true);
            WriteLiteral("                        <video class=\"thumbnail\" controls>\r\n                            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2109, "\"", 2178, 2);
            WriteAttributeValue("", 2115, "https://imgrepository.blob.core.windows.net/images/", 2115, 51, true);
#line 72 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2166, post.ImgUrl, 2166, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2179, 57, true);
            WriteLiteral(" type=\"video/webm\" />\r\n                        </video>\r\n");
            EndContext();
#line 74 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2308, 46, true);
            WriteLiteral("                        <img class=\"thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2354, "\"", 2423, 2);
            WriteAttributeValue("", 2360, "https://imgrepository.blob.core.windows.net/images/", 2360, 51, true);
#line 77 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2411, post.ImgUrl, 2411, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2424, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 78 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#line 78 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2469, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(2505, 11, false);
#line 81 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 46, true);
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
            EndContext();
            BeginContext(2563, 13, false);
#line 83 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2576, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2600, 12, false);
#line 84 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
           Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2612, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2653, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c31463022381", async() => {
                BeginContext(2694, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"PostID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2750, "\"", 2771, 1);
#line 87 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2758, post.ReplyID, 2758, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2772, 88, true);
                WriteLiteral(" /><button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2867, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 91 "C:\Users\wwstudent\Documents\GitHub\TwaddleCate\TwaddleCate\TextForum\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2910, 19, true);
            WriteLiteral("</table>\r\n<hr />\r\n[");
            EndContext();
            BeginContext(2929, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c31463025124", async() => {
                BeginContext(2979, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2994, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(2998, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c31463026711", async() => {
                BeginContext(3047, 10, true);
                WriteLiteral("List Roles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3061, 4, true);
            WriteLiteral("]\r\n[");
            EndContext();
            BeginContext(3065, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d0df87306649d0d5b033f92d7cb8d00c31463028297", async() => {
                BeginContext(3109, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3117, 9, true);
            WriteLiteral("]\r\n<hr />");
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
