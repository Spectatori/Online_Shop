using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Uniform>> RetrieveByGuid(Guid guid)
        {
            var clothing = await db.Uniforms.Where(u=>u.ShirtId == guid).ToListAsync();
            if(clothing == null)
            {
                clothing = await db.Uniforms.Where(u => u.PantsId == guid).ToListAsync();
            }
            return clothing;
        }
        public async Task<List<Uniform>> RetrieveAllClothes()
        {
            var clothes = await db.Uniforms.ToListAsync();
            return clothes;
        }
    }
}