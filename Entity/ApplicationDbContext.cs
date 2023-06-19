using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AuthenticateModel> Athentication { get; set; }
        public DbSet<UserdetailsModel> UserDetails { get; set; }

    }
}