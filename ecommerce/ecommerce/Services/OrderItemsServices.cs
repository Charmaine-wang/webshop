using System;
using System.Collections.Generic;
using ecommerce.Models;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using ecommerce.Repositories;

namespace ecommerce.Services
{
    public class OrderItemsServices
    {
        private readonly OrderItemsRepository orderItemsRepository;

        public OrderItemsServices(OrderItemsRepository orderItemsRepository)
        {
            this.orderItemsRepository = orderItemsRepository;

        }

        public List<OrderItems> Get(string guid)
        {
            return this.orderItemsRepository.Get(guid);
        }





    }
}
