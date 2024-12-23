﻿using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Context;
using CSharpEducation301.DataAccessLayer.Repositories;
using CSharpEducation301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> ProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();

            return values.Cast<object>().ToList();

        }
    }
}
