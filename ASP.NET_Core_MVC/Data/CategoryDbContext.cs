using ASP.NET_Core_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_MVC.Data
{
    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
