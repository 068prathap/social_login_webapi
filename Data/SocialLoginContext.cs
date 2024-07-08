using Microsoft.EntityFrameworkCore;
using SocialLoginWebApi.Models;

namespace SocialLoginWebApi.Data
{
    public class SocialLoginContext : DbContext
    {
        public SocialLoginContext(DbContextOptions<SocialLoginContext> options) :base(options){}

        public DbSet<SocialLoginUsers> SocialLoginUsers { get; set; }
    }
}
