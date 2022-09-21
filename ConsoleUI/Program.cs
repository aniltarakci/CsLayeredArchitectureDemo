using Business;
using DataAccess;
using Entities;

ProductManager productManager = new ProductManager(new ProductDal());

//productManager.Add(new Product { CategoryId = 1, ProductName = "Kırmızı Tişört", UnitPrice = 320, UnitsInStock = 230 });
//productManager.Update(new Product { ProductId = 5, CategoryId = 2, ProductName = "Kırmızı Şort", UnitPrice = 500, UnitsInStock = 1000 });
//productManager.Delete(new Product { ProductId = 3 });

//Console.WriteLine(productManager.GetById(3).ProductName);

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}