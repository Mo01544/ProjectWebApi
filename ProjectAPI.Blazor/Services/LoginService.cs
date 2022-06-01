using ProjectWebAPI.SharedClasses;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Services
{
    public class LoginService : ILoginService<ApplicationUser>
    {
        HttpClient HttpClient;
        public LoginService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }
        public async Task Insert(ApplicationUser item)
        {
            await HttpClient.PostAsJsonAsync<ApplicationUser>("/api​/Acount​/login", item);
        }
    }
}
