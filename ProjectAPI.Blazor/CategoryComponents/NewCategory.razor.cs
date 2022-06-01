using Microsoft.AspNetCore.Components;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.CategoryComponents
{
    public partial class NewCategory
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Parameter]
        public string Name { get; set; }
        public Category Category { get; set; }=new Category();
        public List<Category> Categories { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Categories =await categoryService.GetList();
            await base.OnInitializedAsync();
        }
        public void Add()
        {
            categoryService.Insert(Category);
            categoryService.GetList();
        }
    }
}
