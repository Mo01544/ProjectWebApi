#pragma checksum "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b487e44216d351e28db6d9eb19af6b67f78e5a"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectWebAPI.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.SharedClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.Blazor.CategoryComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\_Imports.razor"
using ProjectWebAPI.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"" b-jkmfdvzkhd>


<link href=""_content/Havit.Blazor.Components.Web.Bootstrap/defaults.css"" rel=""stylesheet"" b-jkmfdvzkhd>


<link href=""Your.Blazor.Project.Assembly.Name.styles.css"" rel=""stylesheet"" b-jkmfdvzkhd>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", " margin:3em;");
            __builder.AddAttribute(3, "b-jkmfdvzkhd");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                 User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                                        LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "class", "col-4 m-auto shadow-lg p-3 mb-3 bg-body rounded m-10");
            __builder.AddAttribute(8, "style", "padding:3em;");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n");
                __builder2.AddMarkupContent(12, "<h1 class=\"shadow p-3 mb-3 bg-body rounded\" style=\"text-align:center; color:white; font-weight:600; background-color:#060606e4;\" b-jkmfdvzkhd>Sign In</h1>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "b-jkmfdvzkhd");
                __builder2.AddMarkupContent(15, "<label style=\"margin-left:.5em; font-weight:500; font-size:1.5em; \" b-jkmfdvzkhd>User name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control shadow p-3 mb-3 bg-body rounded");
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                                    User.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.UserName = __value, User.UserName))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n             ");
                __Blazor.ProjectWebAPI.Blazor.Shared.Login.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 18 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                                     ()=>User.UserName

#line default
#line hidden
#nullable disable
                , 24, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "b-jkmfdvzkhd");
                __builder2.AddMarkupContent(28, "<label style=\"margin-left:.5em; font-weight:500; font-size:1.5em; \" b-jkmfdvzkhd>Password</label>\r\n            ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "password");
                __builder2.AddAttribute(31, "class", "form-control shadow p-3 mb-3 bg-body rounded");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                          User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Password = __value, User.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(34, "b-jkmfdvzkhd");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n             ");
                __Blazor.ProjectWebAPI.Blazor.Shared.Login.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 23 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\Shared\Login.razor"
                                     ()=>User.Password

#line default
#line hidden
#nullable disable
                , 38, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n      ");
                __builder2.AddMarkupContent(40, "<a href=\"\\Admin\" class=\"btn\" style=\"width:45%; background-color: darkgreen; color:white; margin-left:30%; font-size:1em;\" b-jkmfdvzkhd>Login</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ProjectWebAPI.Blazor.Shared.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591