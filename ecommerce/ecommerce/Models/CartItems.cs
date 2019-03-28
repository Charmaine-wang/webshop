using System;
namespace ecommerce.Models
{
    //all the carts from all the customers
    public class CartItems
    {
        public int id { get; set; }
        public string cart_guid { get; set; }
        public int product_id { get; set; }
        public int product_qty { get; set; }
    
    }
}
