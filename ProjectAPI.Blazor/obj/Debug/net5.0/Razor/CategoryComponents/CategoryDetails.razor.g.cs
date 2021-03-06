#pragma checksum "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c48795c8ed65c7bdfb51dd0bbb9a3d502a3572"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category-Details/{id:int}")]
    public partial class CategoryDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
 if(Category!=null){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "mb-5");
#nullable restore
#line 6 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
__builder.AddContent(2, Category.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display:flex; flex-wrap:wrap;");
#nullable restore
#line 8 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
     foreach(var product in Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddAttribute(8, "style", "width: 15em; margin:auto;");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "card-img-top");
            __builder.AddAttribute(11, "src", "/Images/" + (
#nullable restore
#line 11 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
                                          product.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "alt", "Card image cap");
            __builder.AddAttribute(13, "style", "height:10em;");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n  ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.OpenElement(17, "h2");
            __builder.AddAttribute(18, "class", "card-title");
#nullable restore
#line 13 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
__builder.AddContent(19, product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddContent(23, "Price: ");
#nullable restore
#line 14 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
__builder.AddContent(24, product.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "\\Product-Details\\" + (
#nullable restore
#line 15 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
                               product.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "style", "margin-left:4em;");
            __builder.AddContent(30, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"

}else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<h3>Loading...</h3>");
#nullable restore
#line 23 "E:\laps\Web API\Project\ProjectWebAPI\ProjectWebAPI\ProjectWebAPI.Blazor\CategoryComponents\CategoryDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Product> productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Category> categoryService { get; set; }
    }
}
#pragma warning restore 1591
