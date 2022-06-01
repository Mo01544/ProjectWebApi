using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Services
{
    public interface IService<T>
    {
        Task<List<T>> GetList();
        Task<T> GetById(int id);
        Task Insert(T item);
        Task Update(int id, T item);
        Task Delete(int id);
    }
}
