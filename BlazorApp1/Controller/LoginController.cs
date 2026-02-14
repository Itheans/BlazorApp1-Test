using BlazorApp1.Interface;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Controller
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService extServices;
        public LoginController(ILoginService service)
        {
            extServices = service;
        }

        [HttpGet("action")]
        public async Task<Personal> LoginById(Personal model)
        {
            try
            {
                var result = await extServices.LoginById(model);
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
