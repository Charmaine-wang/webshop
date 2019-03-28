using System;

namespace ecommerce.Models
{
    //all the products for the webshop
    public class Products
    {

        public int Id { get; set; }
        public string product_name { get; set; }
        public int product_quantity { get; set; }
        public string product_description { get; set; }
        public string product_img { get; set; }
        public int product_price { get; set; }

    }
}
