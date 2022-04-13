using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class UserDetailsContext : DbContext
    {
        public UserDetailsContext(DbContextOptions<UserDetailsContext> options): base(options)
        {

        }

        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
