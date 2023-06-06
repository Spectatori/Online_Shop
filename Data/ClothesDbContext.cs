using Microsoft.EntityFrameworkCore;
using Online_Shop.Models;

namespace Online_Shop.Data
{
    public class ClothesDbContext : DbContext
    {
        public DbSet<Uniform> Uniforms { get; set; }
        public DbSet<Pants> Pants { get; set; }
        public DbSet<Shirt> Shirts { get; set; }

        public ClothesDbContext(DbContextOptions<ClothesDbContext> options) : base(options) //Извиквам base и слагам options
        {
        }
    }
}