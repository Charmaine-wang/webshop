using System;
using System.Collections.Generic;
using ecomerce.Models;

namespace ecomerce.Services
{
    public class CartServices
    {
        private readonly CartRepository cartRepository;

        public CartServices(CartRepository productRepository)
        {
            this.cartRepository = productRepository;

        }

        public List<Cart> Get()
        {
            return this.cartRepository.Get();
        }


        public Cart Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            return this.cartRepository.Get(id);
        }
    }
}
