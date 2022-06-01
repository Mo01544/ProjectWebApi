using Microsoft.AspNetCore.Components;
using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Components
{
        public partial class AllProducts
        {
        [Parameter]
        public int id { get; set; }
        public List<Product> products { get; set; }
        protected async override Task OnInitializedAsync()
        {
            products = await productService.GetList();
            await base.OnInitializedAsync();
        }
        public async Task Delete(int id)
        {
           await productService.Delete(id);
            await productService.GetList();
        }
    }
    }
