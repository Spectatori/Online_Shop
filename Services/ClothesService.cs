using Online_Shop.Data;
using Online_Shop.Models;

namespace Online_Shop.Services
{
    public class ClothesService
    {
        private readonly ClothesDbContext db;

        public ClothesService(ClothesDbContext db)
        {
            this.db = db;
        }

        public async Task<int> AddShirt(Shirt shirt)
        {
            await db.Shirts.AddAsync(shirt);
            return await db.SaveChangesAsync();
        }
        public async Task<int> AddPants(Pants pants)
        {
            await db.Pants.AddAsync(pants);
            return await db.SaveChangesAsync();
        }
    }
}