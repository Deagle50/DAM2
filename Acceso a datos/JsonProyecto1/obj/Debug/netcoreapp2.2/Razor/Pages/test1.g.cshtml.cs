#pragma checksum "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf4a4b787476a3a78d38a559c47e3d864efb3d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JsonProyecto1.Pages.Pages_test1), @"mvc.1.0.razor-page", @"/Pages/test1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/test1.cshtml", typeof(JsonProyecto1.Pages.Pages_test1), null)]
namespace JsonProyecto1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\_ViewImports.cshtml"
using JsonProyecto1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf4a4b787476a3a78d38a559c47e3d864efb3d1", @"/Pages/test1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346b393a7823b2a57f683337a945dc08538752b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_test1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
  
    ViewData["Title"] = "Página Test 1";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf4a4b787476a3a78d38a559c47e3d864efb3d13349", async() => {
                BeginContext(83, 158, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        input{\r\n            border-radius:5px;\r\n        }\r\n\r\n        div{\r\n            margin:2px;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(248, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(252, 921, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bf4a4b787476a3a78d38a559c47e3d864efb3d14713", async() => {
                BeginContext(258, 40, true);
                WriteLiteral("\r\n\r\n    <div class=\"head\">\r\n        <h1>");
                EndContext();
                BeginContext(299, 17, false);
#line 23 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(316, 475, true);
                WriteLiteral(@"           
        </h1>        
    </div>
    <div class=""main"">
        
        <!-- <div id=divPost>
            <form method=""post"">
                Nombre: 
                    <input type=""text"" asp-for=""nombre""><br/>
                Apellido:
                    <input type=""text"" asp-for=""apellido""><br/>
                <input type=""submit"" id=""btnPost"" title=""Submit""><br/>
            </form>
        </div> -->

        <div>
        <table>
");
                EndContext();
#line 40 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
          foreach (var persona in Model.empleados)
         {

#line default
#line hidden
                BeginContext(855, 63, true);
                WriteLiteral("             <tr>\r\n                 <td>\r\n                     ");
                EndContext();
                BeginContext(919, 14, false);
#line 44 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
                Write(persona.nombre);

#line default
#line hidden
                EndContext();
                BeginContext(933, 70, true);
                WriteLiteral("\r\n                 </td>\r\n                 <td>\r\n                     ");
                EndContext();
                BeginContext(1004, 16, false);
#line 47 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
                Write(persona.apellido);

#line default
#line hidden
                EndContext();
                BeginContext(1020, 46, true);
                WriteLiteral("\r\n                 </td>\r\n             </tr>\r\n");
                EndContext();
#line 50 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
         }

#line default
#line hidden
                BeginContext(1078, 88, true);
                WriteLiteral("         </table>\r\n        </div>\r\n\r\n    </div>\r\n    \r\n\r\n    <script>\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test1Model>)PageContext?.ViewData;
        public Test1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
