using System;
using System.Collections.Generic;
using ecommerce.Models;
using ecommerce.Repositories;

namespace ecommerce.Services
{
    public class ProductServices
    {
        private readonly ProductsRepository productRepository;

        public ProductServices(ProductsRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public List<Products> Get()
        {
            return this.productRepository.Get();
        }


        public List<Products> Get(string key)
        {
            return this.productRepository.Get(key);
        }


    }
}
