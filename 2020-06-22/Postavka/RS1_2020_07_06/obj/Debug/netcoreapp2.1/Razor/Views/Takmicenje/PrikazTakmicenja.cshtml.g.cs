#pragma checksum "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ef7922ad85a80068b195e1afef35716f1bcd29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_PrikazTakmicenja), @"mvc.1.0.view", @"/Views/Takmicenje/PrikazTakmicenja.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/PrikazTakmicenja.cshtml", typeof(AspNetCore.Views_Takmicenje_PrikazTakmicenja))]
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
#line 2 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\_ViewImports.cshtml"
using RS1_2020_07_06.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ef7922ad85a80068b195e1afef35716f1bcd29", @"/Views/Takmicenje/PrikazTakmicenja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3adb0d8e0d19d016603a31554a872f9e6d482745", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_PrikazTakmicenja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrikazTakmicenjaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezultati", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 330, true);
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Skola</th>
            <th>Razred</th>
            <th>Datum</th>
            <th>Predmet</th>
            <th>Najbolji ucesnik (Skola | Odjeljenje | Ime i prezime)</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
         foreach(var item in Model.Rows)
        {

#line default
#line hidden
            BeginContext(417, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(456, 10, false);
#line 21 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
               Write(item.Skola);

#line default
#line hidden
            EndContext();
            BeginContext(466, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(494, 11, false);
#line 22 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
               Write(item.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(505, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(533, 10, false);
#line 23 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
               Write(item.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(543, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(571, 12, false);
#line 24 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
               Write(item.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(583, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(611, 20, false);
#line 25 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
               Write(item.NajboljiUcesnik);

#line default
#line hidden
            EndContext();
            BeginContext(631, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(658, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b12f4899766401cbe01188153524c67", async() => {
                BeginContext(718, 8, true);
                WriteLiteral("Rezultat");
                EndContext();
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
#line 26 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
                                                WriteLiteral(item.TakmicenjeID);

#line default
#line hidden
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
            EndContext();
            BeginContext(730, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
        }

#line default
#line hidden
            BeginContext(767, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(791, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c8936d48d004883995c7aaeaee48b87", async() => {
                BeginContext(867, 5, true);
                WriteLiteral("Dodaj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\LENOVO\Desktop\Razvoj-Softvera-1-master\Razvoj-Softvera-1-master\Ispiti\2020-06-22\Postavka\RS1_2020_07_06\Views\Takmicenje\PrikazTakmicenja.cshtml"
                                                WriteLiteral(Model.SkolaID);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrikazTakmicenjaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
