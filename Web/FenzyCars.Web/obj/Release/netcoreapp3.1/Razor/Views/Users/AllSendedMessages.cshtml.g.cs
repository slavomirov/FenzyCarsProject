#pragma checksum "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd0d8911b596f822b118151d013e38a1b6471d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AllSendedMessages), @"mvc.1.0.view", @"/Views/Users/AllSendedMessages.cshtml")]
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
#line 1 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\_ViewImports.cshtml"
using FenzyCars.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\_ViewImports.cshtml"
using FenzyCars.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd0d8911b596f822b118151d013e38a1b6471d7", @"/Views/Users/AllSendedMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd866b82a01a22f2ab45b4eca8382b180882741", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AllSendedMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FenzyCars.Web.ViewModels.Messages.SendedMessagesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllSendedMessages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
 foreach (var message in Model.Messages)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>");
#nullable restore
#line 6 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
   Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h3>Reciever: ");
#nullable restore
#line 7 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
             Write(message.Reciever.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                         Write(message.Reciever.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h5>");
#nullable restore
#line 8 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
   Write(message.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <hr />\r\n");
#nullable restore
#line 10 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"...\">\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 14 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
         if (Model.PageNumber > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd0d8911b596f822b118151d013e38a1b6471d76079", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 535, "\"", 607, 2);
            WriteAttributeValue("", 543, "page-item", 543, 9, true);
            WriteAttributeValue(" ", 552, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 18 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                              if (!Model.HasPreviousPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 18 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                                                                  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 553, 54, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd0d8911b596f822b118151d013e38a1b6471d79102", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                                                  WriteLiteral(Model.PreviousPageNumber);

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
            WriteLiteral("\r\n        </li>\r\n        <li class=\"page-item active\" aria-current=\"page\">\r\n            <span class=\"page-link\">\r\n                ");
#nullable restore
#line 23 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
           Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"sr-only\">(current)</span>\r\n            </span>\r\n        </li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 980, "\"", 1048, 2);
            WriteAttributeValue("", 988, "page-item", 988, 9, true);
            WriteAttributeValue(" ", 997, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 27 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                              if (!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 27 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                                                              }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 998, 50, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd0d8911b596f822b118151d013e38a1b6471d712929", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                                                  WriteLiteral(Model.NextPageNumber);

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
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 30 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
         if (Model.PageNumber < Model.PagesCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd0d8911b596f822b118151d013e38a1b6471d715537", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
                                                                                        WriteLiteral(Model.PagesCount);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 33 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Users\AllSendedMessages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FenzyCars.Web.ViewModels.Messages.SendedMessagesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
