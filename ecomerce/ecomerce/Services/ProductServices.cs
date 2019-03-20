using System;
using System.Collections.Generic;
using ecomerce.Models;
using ecomerce.Repositories;

namespace ecomerce.Services
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


        //public Products Get(int id)
        //{
        //    if (id < 1)
        //    {
        //        return null;
        //    }
        //    return this.productRepository.Get(id);
        //}
        //public bool Add(News news)
        //{
        //    if (string.IsNullOrEmpty(news.Header) || string.IsNullOrEmpty(news.Body))
        //    {
        //        return false;
        //    }

        //    this.newsRepository.Add(news);
        //    return true;
        //}

    }
}
