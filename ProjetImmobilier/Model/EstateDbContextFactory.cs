using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProjetImmobilier.Model
{
    public class EstateDbContextFactory : IDesignTimeDbContextFactory<EstateDbContext>
    {
        public EstateDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EstateDbContext>();
            optionsBuilder.UseSqlite("Data Source=estate.db");

            return new EstateDbContext(optionsBuilder.Options);
        }
    }

}
