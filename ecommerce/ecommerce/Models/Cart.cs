using System;
namespace ecommerce.Models
{
    //here you will get all the product that the customer have valt
    public class Cart
    {
        public int id { get; set; }
        public string cart_guid { get; set; }
        public int product_id { get; set; }
        public int product_qty { get; set; }
        public string product_name { get; set; }
        public string product_img { get; set; }
        public string product_description { get; set; }
    }
}
