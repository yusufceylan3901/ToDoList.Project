#pragma checksum "C:\Users\hp\Desktop\GitHub\ToDoList.Project\Eltemtek.ToDoList.Web\Views\Home\DeleteProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d80020b92312ba87158dc78847f69b7f3a2577f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeleteProfile), @"mvc.1.0.view", @"/Views/Home/DeleteProfile.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\GitHub\ToDoList.Project\Eltemtek.ToDoList.Web\Views\_ViewImports.cshtml"
using Eltemtek.ToDoList.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\GitHub\ToDoList.Project\Eltemtek.ToDoList.Web\Views\_ViewImports.cshtml"
using Eltemtek.ToDoList.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d80020b92312ba87158dc78847f69b7f3a2577f", @"/Views/Home/DeleteProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a7b3568fe53e853b85c99d26f6f740997824ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DeleteProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Desktop\GitHub\ToDoList.Project\Eltemtek.ToDoList.Web\Views\Home\DeleteProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title"">Create Profile</h4>
                        <p class=""card-category"">Please Fill In The Requested Information</p>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">

                            <div class=""col-md-8"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Do You Want To Delete Your Account</label>
                                </div>
                            </div>
                        </div>
                        <button id=""btnUp"" class=""btn btn-primary pull-right"" type=""button"">Delete Profile</button>

");
            WriteLiteral(@"                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<script type=""text/javascript"">
    $(""#btnUp"").on('click', function () {

            var data1 =
            {
                Id: ");
#nullable restore
#line 45 "C:\Users\hp\Desktop\GitHub\ToDoList.Project\Eltemtek.ToDoList.Web\Views\Home\DeleteProfile.cshtml"
               Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            };

            console.log(data1);

            $.ajax({
                type: ""POST"",
                url: ""/api/UserApi/Delete"",
                data: JSON.stringify(data1),
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: function () {
                    console.log(""success"");
                }
            });
            return false;
        });


</script>");
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
