#pragma checksum "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b410548209cacb008f79b13a086a74bc11e8014f537b5f2632c8da2bdd95f8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ById), @"mvc.1.0.view", @"/Views/Cars/ById.cshtml")]
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
#line (1,2)-(2,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\_ViewImports.cshtml"
using FenzyCars.Web

#nullable disable
    ;
#nullable restore
#line (2,2)-(3,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\_ViewImports.cshtml"
using FenzyCars.Web.ViewModels

#nullable disable
    ;
#nullable restore
#line (1,2)-(2,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
using FenzyCars.Web.ViewModels.Cars;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b410548209cacb008f79b13a086a74bc11e8014f537b5f2632c8da2bdd95f8d3", @"/Views/Cars/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"618a1a68323122da1b94713f6de9264c196cd43d04e96d7d85526f507798020f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsByIdViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line (3,3)-(5,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"

    this.ViewData["Title"] = Model.Make + " " + Model.Model;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
            Write(
#nullable restore
#line (9,6)-(9,28) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
this.ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n");
#nullable restore
#line (10,2)-(12,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
if (Model.LoggedUserId == Model.User.Id)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div style=\"float:left\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b410548209cacb008f79b13a086a74bc11e8014f537b5f2632c8da2bdd95f8d37536", async() => {
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
            WriteLiteral(
#nullable restore
#line (13,97)-(13,105) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b410548209cacb008f79b13a086a74bc11e8014f537b5f2632c8da2bdd95f8d310075", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line (17,80)-(17,88) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <button class=\"btn btn-danger btn-pill\" data-toggle=\"modal\" data-target=\"#deleteModal\">Delete</button>\r\n    </div>\r\n");
#nullable restore
#line (21,1)-(22,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("<hr />\r\n\r\n\r\n<meta charset=\"utf-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line (30,11)-(32,9) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"

            var first = true;
        

#line default
#line hidden
#nullable disable

#nullable restore
#line (33,10)-(35,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
foreach (var item in Model.Images)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 992, "\"", 1054, 2);
            WriteAttributeValue("", 1000, "carousel-item", 1000, 13, true);
            WriteAttributeValue(" ", 1013, 
#nullable restore
#line (35,41)-(35,78) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
first?Html.Raw("active"):Html.Raw("")

#line default
#line hidden
#nullable disable
            , 1014, 40, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"d-block\" style=\"width: inherit; height: inherit;\"");
            BeginWriteAttribute("src", " src=\"", 1135, "\"", 1161, 1);
            WriteAttributeValue("", 1141, 
#nullable restore
#line (36,85)-(36,104) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
item.RemoteImageUrl

#line default
#line hidden
#nullable disable
            , 1141, 20, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"......\">\r\n            </div>\r\n");
#nullable restore
#line (38,1)-(40,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
            first = false;
        }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button""
       data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button""
       data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<hr />


<h4>Price: ");
            Write(
#nullable restore
#line (56,13)-(56,24) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n<hr />\r\n\r\n<h5>Engine size: ");
            Write(
#nullable restore
#line (59,19)-(59,35) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.EngineSize

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Horsepower: ");
            Write(
#nullable restore
#line (60,18)-(60,26) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Hp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Fuel: ");
            Write(
#nullable restore
#line (61,12)-(61,26) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.FuelType

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\r\n<hr />\r\n\r\n<h5>Body: ");
            Write(
#nullable restore
#line (65,12)-(65,26) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.BodyType

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Seats: ");
            Write(
#nullable restore
#line (66,13)-(66,24) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Seats

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Color: ");
            Write(
#nullable restore
#line (67,13)-(67,24) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Color

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Transmission: ");
            Write(
#nullable restore
#line (68,20)-(68,38) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Transmission

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n<h5>Mileage: ");
            Write(
#nullable restore
#line (69,15)-(69,28) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Mileage

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" km</h5>\r\n<h5>Year: ");
            Write(
#nullable restore
#line (70,12)-(70,22) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Year

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\r\n<hr />\r\n\r\n<h5>Description: ");
            Write(
#nullable restore
#line (74,19)-(74,36) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\r\n");
            Write(
#nullable restore
#line (76,2)-(76,23) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.User.CityLiving

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n<br />\r\n");
            Write(
#nullable restore
#line (78,2)-(78,22) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.User.FirstName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line (78,24)-(78,43) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.User.LastName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n<br />\r\n");
            Write(
#nullable restore
#line (80,2)-(80,24) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.User.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n<hr />\r\n");
#nullable restore
#line (83,2)-(85,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
if (this.User.Identity.IsAuthenticated && Model.LoggedUserId != Model.User.Id)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b410548209cacb008f79b13a086a74bc11e8014f537b5f2632c8da2bdd95f8d320464", async() => {
                WriteLiteral("Send Message");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line (85,96)-(85,109) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.User.Id

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
            WriteLiteral("\r\n");
#nullable restore
#line (86,1)-(87,1) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"modal\" tabindex=\"-1\" role=\"dialog\" id=\"deleteModal\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-body\">\r\n                <p>Do you want to delete \"");
            Write(
#nullable restore
#line (92,44)-(92,54) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Make

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ");
            Write(
#nullable restore
#line (92,56)-(92,67) "C:\Users\spart\Desktop\project\FenzyCarsProject\Web\FenzyCars.Web\Views\Cars\ById.cshtml"
Model.Model

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"""?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" onclick=""deleteForm.submit()"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsByIdViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591