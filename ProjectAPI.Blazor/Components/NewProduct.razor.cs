using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;
using ProjectWebAPI.Blazor.Shared;

namespace ProjectWebAPI.Blazor.Components
{
    public partial class NewProduct
    {
        [Parameter]
        public int id { get; set; }
        public Product Product { get; set; } = new Product();
        public List<Category> Categories { get; set; } = new List<Category>();
        protected override async Task OnInitializedAsync()
        {
            Categories = await categoryService.GetList();
            await base.OnInitializedAsync();
        }
        public async Task AddProduct()
        {
            await productService.Insert(Product);
        }
    }
}
