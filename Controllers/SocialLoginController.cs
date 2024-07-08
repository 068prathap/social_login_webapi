using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialLoginWebApi.Data;
using SocialLoginWebApi.Models;

namespace SocialLoginWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialLoginController : ControllerBase
    {
        public readonly SocialLoginContext Context;

        public SocialLoginController(SocialLoginContext context)
        {
            Context = context;
        }

        [HttpPost]
        [Route ("/addUser")]
        public async Task<IActionResult> AddUser(SocialLoginUsers socialLoginUsers)
        {
            Context.SocialLoginUsers.Add(socialLoginUsers);
            await Context.SaveChangesAsync();
            //Context.Database.SqlQueryRaw<string>("");
            //Context.SocialLoginUsers.ExecuteDelete();
            //int count =Context.Database.ExecuteSqlRaw("");
            return Ok();
        }
    }
}