using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        //public Product GetProduct(int id)
        //{
        //    using (var dbContext = new WebContextDb())
        //    {
        //        return dbContext.Products.FirstOrDefault(x => x.ID == id);
        //    }
        //}

        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {ID=1, Description="Cristal", Price=3,CreateDate=null},
                new Product {ID=2, Description="Pilse", Price=0, CreateDate=DateTime.Now},
                new Product {ID=3, Description="Cuzqueña", Price=5, CreateDate=null}
            };
        }
    }
}
