#pragma checksum "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c42ad004f50b208b0969247d66eaca308bc18f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c42ad004f50b208b0969247d66eaca308bc18f1", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075ba95eb5a94d54589986da53d281470654afe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
  
    var prd = (ProductModel) ViewData["Product"];
    ViewData["Title"] = "Search Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
  
    if (prd != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table style=""width:100%"" class=""table table-striped table-hover"">
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Price</th>
                <th>Image</th>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 17 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
               Write(prd.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
               Write(prd.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
               Write(prd.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> <img");
            BeginWriteAttribute("src", " src=", 522, "", 535, 1);
#nullable restore
#line 20 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
WriteAttributeValue("", 527, prd.img, 527, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 535, "", 549, 1);
#nullable restore
#line 20 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
WriteAttributeValue("", 540, prd.Name, 540, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100px\"/></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 23 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"width:100%\" class=\"position-absolute top-0 start-50 translate-middle\">\r\n        <h1>404</h1>\r\n        <h3>Product not found</h3>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\3zAl7arbi\RiderProjects\Shopping\Shopping\Views\Products\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
