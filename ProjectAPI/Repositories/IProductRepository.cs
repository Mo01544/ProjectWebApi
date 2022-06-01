using Project.Models;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public interface IProductRepository
    {
       Task <List<Product>> GetAll();
        Task<Product> FindById(int id);
        Task<int> Post(Product Product);
        Task<int> Put(int id, Product Product);
        Task<int> Delete(int id);

    }
}