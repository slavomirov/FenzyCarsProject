#pragma checksum "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f54956d4ff3a31813e7994d19f9a915f84092e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ById), @"mvc.1.0.view", @"/Views/Cars/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f54956d4ff3a31813e7994d19f9a915f84092e", @"/Views/Cars/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd866b82a01a22f2ab45b4eca8382b180882741", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsByIdViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
  
    this.ViewData["Title"] = Model.Make + " " + Model.Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
 if (Model.LoggedUserId == Model.User.Id)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f54956d4ff3a31813e7994d19f9a915f84092e5397", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
                                                                          WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n\r\n<div class=\"row \">\r\n");
#nullable restore
#line 15 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
     foreach (var image in this.Model.Images)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"w-auto p-0 media col-sm-5\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 438, "\"", 465, 1);
#nullable restore
#line 18 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
WriteAttributeValue("", 444, image.RemoteImageUrl, 444, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100 rounded float-right img-responsive\">\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h4>Price: ");
#nullable restore
#line 23 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n\r\n<h5>Engine size: ");
#nullable restore
#line 26 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
            Write(Model.EngineSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Horsepower: ");
#nullable restore
#line 27 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
           Write(Model.Hp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Fuel: ");
#nullable restore
#line 28 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
     Write(Model.FuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<hr />\r\n\r\n<h5>Body: ");
#nullable restore
#line 32 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
     Write(Model.BodyType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Seats: ");
#nullable restore
#line 33 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
      Write(Model.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Color: ");
#nullable restore
#line 34 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
      Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Transmission: ");
#nullable restore
#line 35 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
             Write(Model.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>Mileage: ");
#nullable restore
#line 36 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
        Write(Model.Mileage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" km</h5>\r\n<h5>Year: ");
#nullable restore
#line 37 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<hr />\r\n\r\n<h5>Description: ");
#nullable restore
#line 41 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Write(Model.User.CityLiving);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 45 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
                 Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 47 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Write(Model.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n");
#nullable restore
#line 50 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
 if (this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f54956d4ff3a31813e7994d19f9a915f84092e13040", async() => {
                WriteLiteral("Send Message");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
                                                                                  WriteLiteral(Model.User.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\spart\Desktop\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsByIdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591