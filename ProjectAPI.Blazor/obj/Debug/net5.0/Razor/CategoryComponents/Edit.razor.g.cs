#pragma checksum "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ed7c79a2435269b32e479292b9e37eb34c203e"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectWebAPI.Blazor.CategoryComponents
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditCategory/{id:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "border: 1px solid white; padding: 3em; margin-bottom:100px");
#nullable restore
#line 5 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
 if (Category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                     Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                                              Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n");
                __builder2.AddMarkupContent(8, "<h1 class=\" p-3 mb-3 bg-body rounded\" style=\"text-align:center; color:black; font-weight:600; background-color:white;\">Edit Category</h1>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "<label style=\"  font-weight:500; font-size:1.7em; \">Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control  p-3 mb-3 bg-body rounded");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                                    Category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Name = __value, Category.Name))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n             ");
                __Blazor.ProjectWebAPI.Blazor.CategoryComponents.Edit.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 13 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                                     ()=>Category.Name

#line default
#line hidden
#nullable disable
                , 19, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label style=\"  font-weight:500; font-size:1.7em; \">Image</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control  p-3 mb-3 bg-body rounded");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                                    Category.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Category.Image = __value, Category.Image))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Category.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n             ");
                __Blazor.ProjectWebAPI.Blazor.CategoryComponents.Edit.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 18 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
                                     ()=>Category.Image

#line default
#line hidden
#nullable disable
                , 31, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<div><input type=\"submit\" value=\"Update\" class=\"btn btn-success\" style=\"width:45%; background-color: darkgreen; color:white;\">\r\n        <a href=\"\\All-Categories\" class=\"btn btn-danger\" style=\"width:45%;  margin-left:5.5%;\">Back to list</a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
}else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<h3>Loading...</h3>");
#nullable restore
#line 28 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\Edit.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Category> categoryService { get; set; }
    }
}
namespace __Blazor.ProjectWebAPI.Blazor.CategoryComponents.Edit
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
