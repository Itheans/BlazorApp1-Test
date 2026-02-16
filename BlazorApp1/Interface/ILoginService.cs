using BlazorApp1.Models;

namespace BlazorApp1.Interface
{
    public interface ILoginService
    {
        Task<Personal> LoginById(Personal model);
        Task<Personal> ResgisById(Personal data);
    }
}
