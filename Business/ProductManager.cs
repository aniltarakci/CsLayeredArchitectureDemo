using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Task<List<Product>> GetAllAsync()
        {
            return _productDal.GetAllAsync();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _productDal.GetByIdAsync(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
