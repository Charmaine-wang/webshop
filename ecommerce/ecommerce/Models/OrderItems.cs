using System;
namespace ecommerce.Models
{
    //final köp

    public class OrderItems
    {
        public string cart_guid { get; set; }
        public int product_id { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string product_description { get; set; }
    }
}





