#pragma checksum "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5789502e510333488253bf0bea28832cf8543ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Task), @"mvc.1.0.view", @"/Views/Tests/Task.cshtml")]
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
#line 1 "A:\Work\TestApplication2\TestApplication\Views\_ViewImports.cshtml"
using TestApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Work\TestApplication2\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\Work\TestApplication2\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5789502e510333488253bf0bea28832cf8543ca", @"/Views/Tests/Task.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a1768df4087360e7e14bf1c68d2f33eafdab8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tests_Task : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskAndResult>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
  
    ViewData["Title"] = "Task";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
Write(Model.Task.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5789502e510333488253bf0bea28832cf8543ca3806", async() => {
                WriteLiteral("\r\n    <p>\r\n        <label>");
#nullable restore
#line 11 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
          Write(Model.Task.Answer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <input type=\"radio\" name=\"result\"");
                BeginWriteAttribute("value", " value=\"", 197, "\"", 222, 1);
#nullable restore
#line 12 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
WriteAttributeValue("", 205, Model.Result+1, 205, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </p>\r\n    <p>\r\n        <label>");
#nullable restore
#line 15 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
          Write(Model.Task.FakeAnswer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <input type=\"radio\" name=\"result\"");
                BeginWriteAttribute("value", " value=\"", 335, "\"", 358, 1);
#nullable restore
#line 16 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
WriteAttributeValue("", 343, Model.Result, 343, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </p>\r\n    <input type=\"hidden\" name=\"idTest\"");
                BeginWriteAttribute("value", " value=\"", 412, "\"", 439, 1);
#nullable restore
#line 18 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
WriteAttributeValue("", 420, Model.Task.Test.Id, 420, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <input type=\"hidden\" name=\"idTask\"");
                BeginWriteAttribute("value", " value=\"", 482, "\"", 507, 1);
#nullable restore
#line 19 "A:\Work\TestApplication2\TestApplication\Views\Tests\Task.cshtml"
WriteAttributeValue("", 490, Model.IdTask+1, 490, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <p>\r\n        <input type=\"submit\" value=\"Next\" class=\"btn btn-outline-info\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskAndResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
