using Microsoft.EntityFrameworkCore;


namespace contribuyentesWebAPI.Models
{
    public class dbContext: DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        public DbSet<Contribuyentes>Contribuyentes { get; set; }
    }
}
