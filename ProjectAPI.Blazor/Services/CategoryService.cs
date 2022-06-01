using ProjectWebAPI.DTO;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Services
{
    public class CategoryService : IService<Category>
    {
        HttpClient HttpClient;
        public CategoryService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }

        public async Task Delete(int id)
        {
            await HttpClient.DeleteAsync("/api/Category/" + id);
        }

        public async Task<Category> GetById(int id)
        {
            Category Category = await HttpClient.GetFromJsonAsync<Category>("/api/Category/" + id);
            return Category;
        }

        public async Task<List<Category>> GetList()
        {
            List<Category> Categories = await HttpClient.GetFromJsonAsync<List<Category>>("/api/Category");
            return Categories;
        }

        public async Task Insert(Category item)
        {
            await HttpClient.PostAsJsonAsync<Category>("/api/Category", item);
        }

       
        public async Task Update(int id, Category item)
        {
            await HttpClient.PutAsJsonAsync<Category>("/api/Category/" + id, item);
        }
        
        //public async Task<Category> GetCategoryProducts(int id)
        //{
        //    Category Category = await HttpClient.GetFromJsonAsync<Category>("/api/Category/" + id);
        //    CategoryDataWithProductNameDTO CategoryDTO = new CategoryDataWithProductNameDTO();
        //    foreach (var item in Category.Products)
        //    {
        //        CategoryDTO.ProductName.Add(item.Name);
        //    }
        //    CategoryDTO.CategoryName = Category.Name;
        //    return Category;
        //    //CategoryDTO.Image = Category.Image;

        //}
    }
}
