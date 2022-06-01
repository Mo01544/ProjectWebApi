using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.CategoryComponents
{
    public partial class CategoryDetails
    {
        [Parameter]
        public int id { get; set; }
        public Category Category { get; set; }
        public List<Product> Products{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            Category = await categoryService.GetById(id);
            Products = Category.Products;
            await base.OnInitializedAsync();
        }
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
        }
    }
}
