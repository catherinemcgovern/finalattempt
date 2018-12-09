using Microsoft.EntityFrameworkCore;
using BuffteksWebsite.Models;


namespace BuffteksWebsite.Models

{
    public class BuffteksWebsiteContext : DbContext
    {
        public BuffteksWebsiteContext (DbContextOptions<BuffteksWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BuffteksWebsite.Models.Member> Members { get; set; }
    }
}