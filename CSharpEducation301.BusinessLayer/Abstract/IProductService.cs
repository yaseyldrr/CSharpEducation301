﻿using CSharpEducation301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
    }
}
