#pragma checksum "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd964ac7daed77c40aaa94564c204d3575aa6802"
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
#line 1 "C:\Code\Github\myYAML\myNewDadApp\Views\_ViewImports.cshtml"
using myNewDadApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Github\myYAML\myNewDadApp\Views\_ViewImports.cshtml"
using myNewDadApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd964ac7daed77c40aaa94564c204d3575aa6802", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a047c8556039bf5f3e7d321bb13fe82e8325a8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<h2 class=\"jumbotron\" id=\"weather\">Loading from ");
#nullable restore
#line 12 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                                           Write(Config["WeatherURI"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("...</h2>\r\n\r\n<div class=\'alert alert-warning\'>\r\n    <h3>Environment <b>");
#nullable restore
#line 15 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                  Write(Config["EnvName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n    <hr /><b>Machine:</b> ");
#nullable restore
#line 16 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                     Write(System.Environment.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><b>OS:</b> ");
#nullable restore
#line 17 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                Write(System.Environment.OSVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><b>Framework:</b> ");
#nullable restore
#line 18 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                       Write(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><b>Weather URI:</b> ");
#nullable restore
#line 19 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
                         Write(Config["WeatherURI"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js\"></script>\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n\r\n        $.ajax({\r\n            type: \'GET\',\r\n            url: \'");
#nullable restore
#line 28 "C:\Code\Github\myYAML\myNewDadApp\Views\Home\Index.cshtml"
             Write(Config["WeatherURI"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: 'json',
            success: function (msg) {
                var myWeather = ""<h3><b>myAPI</b> Forcast...<h3><ul>"";
                msg.forEach(obj => { myWeather += ""<li>"" + obj.date + ""  -->  "" + obj.summary + ""</li>"" });
                myWeather += ""</ul>"";
                $('#weather').html(myWeather);

            },
            error: function (request, status, error) {
                $('#joke').html(""Error getting joke"");
            }
        });
    });
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Config { get; private set; }
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
