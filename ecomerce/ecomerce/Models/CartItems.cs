using System;
namespace ecomerce.Models
{
    public class CartItems
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public int Cart_id { get; set; }
        public int Product_quantity { get; set; }
    
    }
}
