using System;
using System.Collections.Generic;

namespace ecommerce.Models
{
    public class FinalOrder
    {

        public Customer customer { get; set; }
        public List<OrderItems> orderItems{ get; set; }

    }
}

