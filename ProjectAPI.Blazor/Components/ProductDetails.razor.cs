using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Components
{
    public partial class ProductDetails
    {
        [Parameter]
        public int id { get; set; }
        public Product Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Product = await productService.GetById(id);
            await base.OnInitializedAsync();
        }
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
        }
    }
}
