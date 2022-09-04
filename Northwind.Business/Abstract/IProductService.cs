using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductByName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}