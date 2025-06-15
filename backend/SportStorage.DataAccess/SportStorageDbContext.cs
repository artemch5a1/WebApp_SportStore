using Microsoft.EntityFrameworkCore;
using SportStorage.DataAccess.Entites;

namespace SportStorage.DataAccess
{
    public class SportStorageDbContext : DbContext
    {
        public SportStorageDbContext(DbContextOptions<SportStorageDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<SportsItemEntity> SportsItems { get; set; }
    }
}
