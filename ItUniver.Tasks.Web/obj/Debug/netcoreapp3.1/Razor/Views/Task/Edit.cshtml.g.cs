#pragma checksum "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc8d1ee16706df83aa22ade713cf4737cfc28a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Edit), @"mvc.1.0.view", @"/Views/Task/Edit.cshtml")]
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
#line 1 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\_ViewImports.cshtml"
using ItUniver.Tasks.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
using ItUniver.Tasks.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc8d1ee16706df83aa22ade713cf4737cfc28a6", @"/Views/Task/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197e92f03f809d90c6ad4fa9866c86e56747ac82", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskEditModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Редактирование задачи - ");
#nullable restore
#line 7 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
                           Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 10 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
         using (Html.BeginForm("Edit", "Task"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Subject));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
       Write(Html.HiddenFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 18 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
           Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
           Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-success\">Сохранить</button>\r\n            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 839, 1);
#nullable restore
#line 23 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
WriteAttributeValue("", 811, Url.Action("Index", "Task"), 811, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Отмена</a>\r\n");
#nullable restore
#line 24 "D:\Curse\ITUNIVER20\ItUniver.Tasks.Web\Views\Task\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
