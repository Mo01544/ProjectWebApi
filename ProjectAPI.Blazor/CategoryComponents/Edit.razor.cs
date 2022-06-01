using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.CategoryComponents
{
    public partial class Edit
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Parameter]
        public int id { get; set; }

        public Category Category { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Category = await categoryService.GetById(id);
            await base.OnInitializedAsync();
        }
        public void Save()
        {
            categoryService.Update(id, Category);
        }
    }
}
