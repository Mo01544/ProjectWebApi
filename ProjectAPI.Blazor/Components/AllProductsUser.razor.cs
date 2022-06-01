using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ProjectWebAPI.Blazor.Components
{
    public partial class AllProductsUser
    {
        public List<Product> products { get; set; }
        protected async override Task OnInitializedAsync()
        {
            products = await productService.GetList();
            await base.OnInitializedAsync();
        }
    }
}
