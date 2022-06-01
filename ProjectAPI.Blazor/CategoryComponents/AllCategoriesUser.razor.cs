using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ProjectWebAPI.Blazor.CategoryComponents
{
    public partial class AllCategoriesUser
    {
        public List<Category> categories { get; set; }
        protected async override Task OnInitializedAsync()
        {
            categories = await categoryService.GetList();
            await base.OnInitializedAsync();
        }
    }
}
