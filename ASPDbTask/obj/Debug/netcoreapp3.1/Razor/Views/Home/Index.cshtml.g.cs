#pragma checksum "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9032d495526bc1c0b760c9011c004baf08d555ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
using ASPDbTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
using ASPDbTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9032d495526bc1c0b760c9011c004baf08d555ba", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<ul>\n");
#nullable restore
#line 10 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
     foreach (Product product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
                     Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" manat CategoryId: ");
#nullable restore
#line 12 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
                                                      Write(product.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
                                                                          Write(product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\kerim\source\repos\ASPDbTask\ASPDbTask\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591