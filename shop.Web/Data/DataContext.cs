

namespace shop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using shop.Web.Data.Entities;
    //IdentityDbContext-> contain the tables of user for is change for dbContext
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Country> countries{ get; set; }

        // conexion for  de data base 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
