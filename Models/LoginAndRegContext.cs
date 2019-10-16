using Microsoft.EntityFrameworkCore;
namespace LoginAndReg.Models
{
    public class LoginAndRegContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public LoginAndRegContext(DbContextOptions options) : base(options) { 
	                          
        }
        public DbSet<User> Users { get; set; }
    }
}