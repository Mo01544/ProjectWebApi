using Microsoft.AspNetCore.Components;
using ProjectWebAPI.Blazor.Services;
using ProjectWebAPI.SharedClasses;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjectWebAPI.Blazor.Shared
{
    public partial class Login
    {
        //        public ApplicationUser user = new ApplicationUser();

        //        public async void HandleLogin()
        //        {
        //            Console.WriteLine("Log me in!");
        //            await LocalStorage.SetItemAsync<string>("username", user.UserName);
        //            //await AuthStateProvider.GetAuthenticationStateAsync();
        //            NavigationManager.NavigateTo("");
        //        }
        //    }

        int id { get; set; }

        HttpClient HttpClient = new HttpClient();
        public ApplicationUser User { get; set; } = new ApplicationUser();
        protected override async Task OnInitializedAsync()
        {
            //id = int.Parse(User.Id);
            //User = await HttpClient.GetFromJsonAsync<ApplicationUser>("/api/Product/" + id);
            await base.OnInitializedAsync();
        }
        public async Task LoginUser()
        {
            if (User.UserName != "Nada" || User.Password != "Nada_1Nada")
            {
                Console.WriteLine("Data wrong");
            }
            else
            {
                //await HttpClient.PostAsJsonAsync<ApplicationUser>("/api​/Acount​/login", User);
                Console.WriteLine("Data wrong");

            }
        }
    }
}
