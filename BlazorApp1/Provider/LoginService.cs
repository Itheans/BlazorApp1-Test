using BlazorApp1.Models;

namespace BlazorApp1.Provider
{
    public class LoginProvider
    {
        private readonly HttpClient httpClient;
        public LoginProvider(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


            public async Task<Personal> LoginById(Personal model)
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("api/Login/LoginById", model);
                    return await response.Content.ReadFromJsonAsync<Personal>();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }

    }
}
