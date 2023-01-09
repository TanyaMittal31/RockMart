using Microsoft.EntityFrameworkCore;
using Rock.Mart.Products.Models;

namespace Rock.Mart.Products.DbContexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
