using Microsoft.AspNetCore.Components;
using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.CategoryComponents
{

    public partial class AllCategories
    {
        [Parameter]
        public int id { get; set; }
        public List<Category> Categories { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Categories = await categoryService.GetList();
            await base.OnInitializedAsync();
        }
        public void Delete(int id)
        {
            categoryService.Delete(id);
            categoryService.GetList();
        }
    }
}
