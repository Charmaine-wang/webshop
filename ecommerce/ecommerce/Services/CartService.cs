using System;
using System.Collections.Generic;
using ecommerce.Models;
using ecommerce.Repositories;

namespace ecommerce.Services
{
    public class CartService
    {

        private CartRepository cartRepository;

        public CartService(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }


        public List<Cart> Get(string guid)
        {
            return this.cartRepository.Get(guid);
        }
    }
}
