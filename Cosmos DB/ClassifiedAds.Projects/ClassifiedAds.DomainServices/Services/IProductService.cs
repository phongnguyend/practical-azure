﻿using ClassifiedAds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassifiedAds.DomainServices
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        Product GetById(string Id);

        Product Create(Product product);

        Product Update(Product product);

        void Delete(Product product);
    }
}
