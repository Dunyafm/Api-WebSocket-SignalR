#pragma checksum "C:\Users\user\Desktop\Asp.Net\WebSocketSignalR\SignalR\SignalR\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd1899a2ae1fafc584a731e3b035eb8779fb946"
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
#line 1 "C:\Users\user\Desktop\Asp.Net\WebSocketSignalR\SignalR\SignalR\Views\_ViewImports.cshtml"
using SignalR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Asp.Net\WebSocketSignalR\SignalR\SignalR\Views\_ViewImports.cshtml"
using SignalR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd1899a2ae1fafc584a731e3b035eb8779fb946", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0305a69484871a126f96009a9524121419a805ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\Asp.Net\WebSocketSignalR\SignalR\SignalR\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"" id=""user-info"">
        <div class=""col-12"">
            <div class=""form-group"">
                <label>Add Username</label>
                <input type=""text"" name=""username"" class=""form-control""  id=""username"" autocomplete=""off""/>
                <button class=""btn btn-outline-success mt-3"" id=""join"" >Join</button>
            </div>
        </div>
    </div>
    <div class=""row"" id=""message-area"" style=""display:none"">
        <div class=""col-12"">
            <div>Join as : <span id=""joiner"">Nobody</span></div>
            <hr />
            <div class=""row"">
                <div class=""col-6"">
                    <ul class=""list-group"" id=""message-list"">

                    </ul>
                </div>
                <div class=""col-6"">
                    <div class=""form-group"">
                        <input type=""text"" name=""username"" class=""form-control"" id=""message"" autocomplete=""off"" />
                        <input type=""butt");
            WriteLiteral("on\" class=\"btn btn-outline-primary mt-3\" value=\"Send Message\" id=\"send-message\"/>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd1899a2ae1fafc584a731e3b035eb8779fb9465030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    let connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build();
    let username = """";

    connection.on(""ReciveMessage"", function (user, message) {
        let userMessage = user + ""says :"" + message;

        let li = `<li class=""list-group-item"">${userMessage}</li>`;
        document.getElementById(""message-list"").innerHTML += li;
    })


    document.getElementById(""send-message"").addEventListener(""click"", function () {
        let message = document.getElementById(""message"").value;

        connection.invoke(""SendMessage"", username, message).then(function () {
            document.getElementById(""message"").value = """";
        }).catch(function () {
            console.error(err.toString())
        });
    })



    connection.start().then(function () {

    }).catch(function () {
        console.error(err.toString())
    });

    document.getElementById(""join"").addEventListener(""click"", function () {
        debugger
        let userInpu");
            WriteLiteral(@"tName = document.getElementById(""username"").value;
        if (username = """") {
            alert(""Please add username"")
            return;
        }
        username = userInputName;
        document.getElementById(""user-info"").style.display = ""none"";
        document.getElementById(""message-area"").style.display = ""block"";
        document.getElementById(""joiner"").innerText = username;
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
