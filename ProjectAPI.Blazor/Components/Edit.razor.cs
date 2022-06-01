using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Components
{
    public partial class Edit
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        public string MsgError { get; set; } = "";
        [Parameter]
        public int id { get; set; }

        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Product = await productService.GetById(id);
            Categories = await categoryService.GetList();
            await base.OnInitializedAsync();
        }
        public void Save()
        {
            productService.Update(id, Product);
        }
    }
}
