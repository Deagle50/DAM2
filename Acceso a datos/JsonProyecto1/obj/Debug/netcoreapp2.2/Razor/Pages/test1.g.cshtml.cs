#pragma checksum "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d142fecbc1e81364aea0b70d324736965fe980"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d142fecbc1e81364aea0b70d324736965fe980", @"/Pages/test1.cshtml")]
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(79, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d142fecbc1e81364aea0b70d324736965fe9803349", async() => {
                BeginContext(85, 410, true);
                WriteLiteral(@"

    <style type=""text/css"">

        h1{
            margin-top:3%;
            margin-bottom:3%;
        }
        
        div{
            margin:2px;
        }

        th{
            padding:6px 15px 6px 15px;
            border: 3px solid lightgray;
        }

        td{
            padding:3px 5px 3px 5px;
            border: 3px solid lightgray;

        }
    </style>

");
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
            BeginContext(502, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(506, 1467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d142fecbc1e81364aea0b70d324736965fe9804945", async() => {
                BeginContext(512, 54, true);
                WriteLiteral("\r\n\r\n    <div class=\"head\">\r\n        <h1>\r\n            ");
                EndContext();
                BeginContext(567, 17, false);
#line 38 "D:\Urko Urbieta\Visual Studio\Acceso a datos\JsonProyecto1\Pages\test1.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(584, 1382, true);
                WriteLiteral(@"           
        </h1>        
    </div>
        <br/>
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

        <!-- <select id=""ddltipo"" runat=""server"">
            <option value=""tipo1"">Tipo1</option>
            <option value=""tipo2"">Tipo2</option>
            <option value=""tipo3"">Tipo3</option>
        </select> -->
        <table>
            <tr>
                <th>
                    Nombre
                </th>
                <th>
                    Dirección
                </th>
                <th>
                    Descripción
                </th>
                <th>
                    Tipo
               ");
                WriteLiteral(@" </th>
                <th>
                    Empleados
                </th>
                <th>
                    Contactos
                </th>
                <th>
                    Oportunidades
                </th>
            </tr>
         
         </table>
        </div>

    </div>
    

    <script>

    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<companyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<companyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<companyModel>)PageContext?.ViewData;
        public companyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591