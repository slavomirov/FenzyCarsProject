#pragma checksum "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1a35742819a2c3416291d8510f7d15eeafb972087fa3fbbe5e3e30e61c6ca38c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Cars_Details), @"mvc.1.0.view", @"/Areas/Administration/Views/Cars/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line (1,2)-(2,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\_ViewImports.cshtml"
using FenzyCars.Web

#nullable disable
    ;
#nullable restore
#line (2,2)-(3,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\_ViewImports.cshtml"
using FenzyCars.Web.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a35742819a2c3416291d8510f7d15eeafb972087fa3fbbe5e3e30e61c6ca38c", @"/Areas/Administration/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"618a1a68323122da1b94713f6de9264c196cd43d04e96d7d85526f507798020f", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FenzyCars.Data.Models.Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line (3,3)-(6,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"

    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Car</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (15,14)-(15,54) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Make)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (18,14)-(18,50) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Make)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (21,14)-(21,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Model)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (24,14)-(24,51) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Model)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (27,14)-(27,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Color)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (30,14)-(30,51) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Color)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (33,14)-(33,52) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Hp)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (36,14)-(36,48) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Hp)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (39,14)-(39,57) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Mileage)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (42,14)-(42,53) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Mileage)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (45,14)-(45,58) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.BodyType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (48,14)-(48,54) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.BodyType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (51,14)-(51,58) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.FuelType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (54,14)-(54,54) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.FuelType)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (57,14)-(57,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Seats)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (60,14)-(60,51) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Seats)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (63,14)-(63,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Doors)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (66,14)-(66,51) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Doors)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (69,14)-(69,62) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Transmission)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (72,14)-(72,58) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Transmission)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (75,14)-(75,60) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.EngineSize)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (78,14)-(78,56) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.EngineSize)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (81,14)-(81,54) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Year)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (84,14)-(84,50) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Year)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (87,14)-(87,61) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (90,14)-(90,57) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (93,14)-(93,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (96,14)-(96,51) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (99,14)-(99,59) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (102,14)-(102,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.IsDeleted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (105,14)-(105,59) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.DeletedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (108,14)-(108,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.DeletedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (111,14)-(111,59) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.CreatedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (114,14)-(114,55) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.CreatedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line (117,14)-(117,60) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayNameFor(model => model.ModifiedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line (120,14)-(120,56) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Html.DisplayFor(model => model.ModifiedOn)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a35742819a2c3416291d8510f7d15eeafb972087fa3fbbe5e3e30e61c6ca38c18506", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line (125,41)-(125,49) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Areas\Administration\Views\Cars\Details.cshtml"
Model.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a35742819a2c3416291d8510f7d15eeafb972087fa3fbbe5e3e30e61c6ca38c20722", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FenzyCars.Data.Models.Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591