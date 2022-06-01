using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using ProjectWebAPI.SharedClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductEntity context;
        public ProductRepository(ProductEntity _context)
        {
            context = _context;
        }
        //    public List<Product> GetAll()
        //    {
        //        return context.Products.ToList();
        //    }

        //    public Product FindById(int id)
        //    {
        //        return context.Products.Include(p => p.Category).FirstOrDefault(x => x.ID == id);
        //    }
        //    public int Post(Product Product)
        //    {
        //        context.Products.Add(Product);
        //        return context.SaveChanges();
        //    }
        //    public int Put(int id, Product Product)
        //    {
        //        Product oldProduct = FindById(id);
        //        if (oldProduct != null)
        //        {
        //            oldProduct.Name = Product.Name;
        //            oldProduct.Price = Product.Price;
        //            oldProduct.Details = Product.Details;
        //            oldProduct.Image= Product.Image;
        //            return context.SaveChanges();
        //        }
        //        return 0;
        //    }
        //    public int Delete(int id)
        //    {
        //        Product DeletedProduct = FindById(id);
        //        context.Products.Remove(DeletedProduct);
        //        return context.SaveChanges();
        //    }
        public async Task<int> Delete(int id)
        {
            Product DeletedProduct = await  FindById(id);
               context.Products.Remove(DeletedProduct);
                return await context.SaveChangesAsync();
        }
        public async Task<Product> FindById(int id)
        {
            return await context.Products.Include(p => p.Category).FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<int> Post(Product Product)
        {
            context.Products.Add(Product);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Put(int id, Product Product)
        {
            Product oldProduct = await FindById(id);
            if (oldProduct != null)
            {
                oldProduct.Name = Product.Name;
                oldProduct.Price = Product.Price;
                oldProduct.Details = Product.Details;
                oldProduct.Image = Product.Image;
                return await context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
