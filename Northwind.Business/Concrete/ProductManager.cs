using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException)
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }

        public Product GetById(int id)
        {
            //business code

            return _productDal.Get(filter:x=>x.ProductId==id);
        }

        public List<Product> GetProductByName(string productName)
        {
            return _productDal.GetAll(x => x.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId== categoryId).ToList();
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        List<Product> IProductService.GetAll()
        {
            return _productDal.GetAll();
        }
    }
}