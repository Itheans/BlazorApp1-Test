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

        [HttpPost("LoginById")]
        public async Task<IActionResult> LoginById([FromBody] Personal model)
        {
            var result = await extServices.LoginById(model);
            if (result == null)
                return null;

            return Ok(result);
        }

        [HttpPost("ResgisById")]
        public async Task<IActionResult> ResgisById([FromBody] Personal data)
        {
            var result = await extServices.ResgisById(data);

            if (result == null)
                return BadRequest("Register failed");

            return Ok(result);
        }
    }
}
