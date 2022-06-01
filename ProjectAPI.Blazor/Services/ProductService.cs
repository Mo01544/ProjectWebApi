using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Services
{
    public class ProductService : IService<Product>
    {
        HttpClient HttpClient;
        public ProductService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }

        public async Task Delete(int id)
        {
            await HttpClient.DeleteAsync("/api/Product/" + id);
        }

        public async Task<Product> GetById(int id)
        {
            Product product = await HttpClient.GetFromJsonAsync<Product>("/api/Product/"+id);
            return product;
        }

        public async Task<List<Product>> GetList()
        {
            List<Product> products = await HttpClient.GetFromJsonAsync<List<Product>>("/api/Product");
            return products;
        }

        public async Task Insert(Product item)
        {
           await HttpClient.PostAsJsonAsync<Product>("/api/Product",item);
        }

        public async Task Update(int id, Product item)
        {
            await HttpClient.PutAsJsonAsync<Product>("/api/Product/" + id,item);
        }
    }
}
