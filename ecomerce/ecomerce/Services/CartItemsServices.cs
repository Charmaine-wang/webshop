using System;
using System.Collections.Generic;
using ecomerce.Models;

namespace ecomerce.Services
{
    public class CartItemsServices
    {
        private readonly CartItemsRepository cartItemsRepository;

        public CartItemsServices(CartItemsRepository productRepository)
        {
            this.cartItemsRepository = productRepository;

        }

        public List<CartItems> Get()
        {
            return this.cartItemsRepository.Get();
        }


        public CartItems Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            return this.cartItemsRepository.Get(id);
        }

        public bool Add(CartItems cartItems)
        {
            if (cartItems != null)
            {
                this.cartItemsRepository.Add(cartItems);
                return true;
            }

            return false;
        }

    }
}
