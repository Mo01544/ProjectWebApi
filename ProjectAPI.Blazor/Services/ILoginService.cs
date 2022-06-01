using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Services
{
    public interface ILoginService<ApplicationUser>
    {
        Task Insert(ApplicationUser item);
    }
}
