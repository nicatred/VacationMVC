#pragma checksum "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\Error\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70dbff64d8e6c9e483c8b60c1883fa117d5a00e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Index), @"mvc.1.0.view", @"/Views/Error/Index.cshtml")]
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
#line 3 "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\_ViewImports.cshtml"
using MvcUI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\_ViewImports.cshtml"
using DataAccess.Dtos.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\_ViewImports.cshtml"
using DataAccess.Entites.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dbff64d8e6c9e483c8b60c1883fa117d5a00e3", @"/Views/Error/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444c6faeee9b3030f72ac1634f4f81f3fcf2f947", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""error-template"">
                <h1>
                    Oops!
                </h1>
                <h2>
                    ");
#nullable restore
#line 15 "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\Error\Index.cshtml"
               Write(Model.StatuCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </h2>\r\n                <div class=\"error-details\">\r\n                   ");
#nullable restore
#line 18 "C:\Users\Nijatred\source\repos\VacationMVC\MvcUI\Views\Error\Index.cshtml"
              Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                </div>
                <div class=""error-actions"">
                    <a href=""http://www.jquery2dotnet.com"" class=""btn btn-primary btn-lg"">
                        <span class=""glyphicon glyphicon-home""></span>
                        Ana səhifə
                    </a><a href=""http://www.jquery2dotnet.com"" class=""btn btn-default btn-lg""><span class=""glyphicon glyphicon-envelope""></span> Bizimlə əlaqə </a>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
