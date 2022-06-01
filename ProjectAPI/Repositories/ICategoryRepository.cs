using Project.Models;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> FindById(int id);
        Task<int> Post(Category Category);
        Task<int> Put(int id, Category Category);
        Task<int> Delete(int id);
        Task<Category> FindByName(string name);
    }
}
