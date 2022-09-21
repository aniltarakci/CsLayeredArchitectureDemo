using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            using (ExampleDbContext exampleDbContext = new ExampleDbContext())
            {
                exampleDbContext.Products.Add(entitiy);
                exampleDbContext.SaveChanges();
            }
        }

        public async Task AddAsync(Product entitiy)
        {
            ExampleDbContext exampleDbContext = new ExampleDbContext();
            await exampleDbContext.Products.AddAsync(entitiy);
            await exampleDbContext.SaveChangesAsync();
        }

        public void Delete(Product entity)
        {
            using (ExampleDbContext exampleDbContext = new ExampleDbContext())
            {
                exampleDbContext.Products.Remove(exampleDbContext.Products.SingleOrDefault(p => p.ProductId == entity.ProductId));
                exampleDbContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (ExampleDbContext exampleDbContext = new ExampleDbContext())
            {
                return exampleDbContext.Products.ToList();
            }
        }

        public Task<List<Product>> GetAllAsync()
        {
            ExampleDbContext exampleDbContext = new ExampleDbContext();
            return exampleDbContext.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (ExampleDbContext exampleDbContext = new ExampleDbContext())
            {
                return exampleDbContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            ExampleDbContext exampleDbContext = new ExampleDbContext();
            return exampleDbContext.Products.SingleOrDefaultAsync(p => p.ProductId == id);
        }

        public void Update(Product entitiy)
        {
            using (ExampleDbContext exampleDbContext = new ExampleDbContext())
            {
                var productToUpdate = exampleDbContext.Products.SingleOrDefault(p => p.ProductId == entitiy.ProductId);
                productToUpdate.CategoryId = entitiy.CategoryId;
                productToUpdate.ProductName = entitiy.ProductName;
                productToUpdate.UnitPrice = entitiy.UnitPrice;
                productToUpdate.UnitsInStock = entitiy.UnitsInStock;
                exampleDbContext.SaveChanges();
            }
        }
    }
}
