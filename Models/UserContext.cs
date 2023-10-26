using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        { 


        }
        public DbSet<Users> Users { get; set; }
            
        
    }
}
