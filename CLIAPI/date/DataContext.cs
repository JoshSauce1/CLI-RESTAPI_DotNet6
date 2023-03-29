using Microsoft.EntityFrameworkCore;

namespace CLIAPI.date
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Commander> Commands { get; set; }
    }
}
