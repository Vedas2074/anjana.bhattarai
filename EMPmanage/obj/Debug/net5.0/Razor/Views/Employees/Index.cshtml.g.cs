#pragma checksum "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627823fc6b67783b1c1efdeeaa8a56c1bbcb6c2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
#line 1 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\_ViewImports.cshtml"
using EMPmanage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\_ViewImports.cshtml"
using EMPmanage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627823fc6b67783b1c1efdeeaa8a56c1bbcb6c2b", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b7ff664c1ea82608368cae9046bad1e488e0f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<People>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>
  this is index file.
</h1>
<table class=""table table-primary"">
  <thead>

  
    <tr class=""table-active"">
    </tr>
    <tr>
      
       <td  class=""table-active"">SN</td>
      <td  class=""table-active"">Firstname</td>
      <td  class=""table-active"">lastname</td>
      <td class=""table-active"">Address</td>
      <td class=""table-active"">Gender</td>
      <td class=""table-active"">Salary</td>
    </tr>
</thead>

<tbody>
");
#nullable restore
#line 24 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
   for (int i=0;i<Model.Count;i++)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr><td>");
#nullable restore
#line 26 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 564, "\"", 615, 2);
            WriteAttributeValue("", 571, "/employees/details?firstname=", 571, 29, true);
#nullable restore
#line 28 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
WriteAttributeValue("", 600, Model[i].Fname, 600, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
                                                          Write(Model[i].Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </td>\r\n     <td>");
#nullable restore
#line 30 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
    Write(Model[i].SN);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 31 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
     Write(Model[i].Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 32 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
     Write(Model[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 33 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
     Write(Model[i].Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 34 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
     Write(Model[i].Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 36 "D:\lab1 of vedas\anjana.bhattarai\EMPmanage\Views\Employees\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<People>> Html { get; private set; }
    }
}
#pragma warning restore 1591
