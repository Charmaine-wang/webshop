using System;
namespace ecomerce.Models
{
    public class Products
    {
        public Products()
        {
        }
        public int Id { get; set; }
        public string product_name { get; set; }
        public int product_quantity { get; set; }
        public string product_description { get; set; }
        public object product_image { get; set; }
        public int product_price { get; set; }

    }
}
