using System;
namespace ecomerce.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Cart_quantity { get; set; }
        public int Cart_price { get; set; }
        public int Product_id { get; set; }


    }
}
