using System;
using System.Collections.Generic;
using System.Web.Http;
using ecommerce.Models;
using ecommerce.Repositories;

namespace ecommerce.Services
{
    public class FinalOrderServices
    {
        private readonly OrderItemsRepository orderItemsRepository;
        private readonly CustomerRepository customerRepository;

        public FinalOrderServices(OrderItemsRepository orderItemsRepository, CustomerRepository customerRepository)
        {
            this.orderItemsRepository = orderItemsRepository;
            this.customerRepository = customerRepository;

        }

        public FinalOrderServices(CustomerRepository customerRepository, OrderItemsRepository orderItemsRepository)
        {
            this.customerRepository = customerRepository;
            this.orderItemsRepository = orderItemsRepository;
        }

        public FinalOrder Get(string guid)
        {
            var customer = this.customerRepository.Get(guid);
            var orderItems = this.orderItemsRepository.Get(guid);

            return new FinalOrder
            {
                customer = customer,
                orderItems = orderItems

            };

        }
    }
}
