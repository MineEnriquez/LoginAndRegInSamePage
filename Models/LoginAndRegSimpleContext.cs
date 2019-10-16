using Microsoft.EntityFrameworkCore;
namespace LoginAndRegSimple.Models
{
    public class LoginAndRegSimpleContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public LoginAndRegSimpleContext(DbContextOptions options) : base(options) { 
	                          
        }
        public DbSet<User> Users { get; set; }
    }
}