using Microsoft.EntityFrameworkCore;
using Project.Models;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ProductEntity context;
        public CategoryRepository(ProductEntity _context)
        {
            context = _context;
        }
        public async Task<int> Delete(int id)
        {
            Category DeletedCategory = await FindById(id);
            context.Categories.Remove(DeletedCategory);
            return await context.SaveChangesAsync();
        }
        public async Task<Category> FindById(int id)
        {
            return await context.Categories.Include(p => p.Products).FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<int> Post(Category Category)
        {
            context.Categories.Add(Category);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Put(int id, Category Category)
        {
            Category oldCategory = await FindById(id);
            if (oldCategory != null)
            {
                oldCategory.Name = Category.Name;
                oldCategory.Image = Category.Image;
                return await context.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<Category> FindByName(string name)
        {
            return await context.Categories.FirstOrDefaultAsync(d => d.Name == name);
        }

    }
}
