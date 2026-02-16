using BlazorApp1.Interface;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Service
{
    public class LoginService : ILoginService
    {
        private readonly AppDbContext db;
        public LoginService(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<Personal> LoginById(Personal model)
        {
            try 
            { 
                var personal = await db.Personals.FirstOrDefaultAsync(x => x.USer == model.USer && x.PassWord == model.PassWord);
                return personal;
            }
            catch (Exception ex)
            {
                return new Personal();
            }
        }

        public async Task<Personal> ResgisById(Personal data)
        {
            try
            {
                var personal = await db.Personals.FirstOrDefaultAsync(x => x.USer == data.USer);
                if (personal != null)
                {
                    return personal;
                }
                else
                {
                    db.Personals.Add(data);
                    await db.SaveChangesAsync();
                    return data;
                }
            }
            catch (Exception ex)
            {
                return new Personal();
            }

        }

    }
}
