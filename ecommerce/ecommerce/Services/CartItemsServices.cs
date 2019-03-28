using System;
using System.Collections.Generic;
using ecommerce.Models;

namespace ecommerce.Services
{
    public class CartItemsServices
    {
        private readonly CartItemsRepository cartItemsRepository;

        public CartItemsServices(CartItemsRepository cartItemsRepository)
        {
            this.cartItemsRepository = cartItemsRepository;

        }

        public List<CartItems> Get()
        {
            return this.cartItemsRepository.Get();
        }

        public CartItems Get(int Cart_guid)
        {
            if (Cart_guid < 1)
            {
                return null;
            }
            return this.cartItemsRepository.Get(Cart_guid);
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
