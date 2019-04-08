using System;
using System.Collections.Generic;
using ecommerce.Models;
using System.Data.SQLite;
using Dapper;
using System.Linq;


namespace ecommerce.Repositories
{
    public class OrderItemsRepository
    {
        private readonly string connectionString;

        public OrderItemsRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<OrderItems> Get()
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<OrderItems>("SELECT * FROM order_items").ToList();
            }
        }



        public List<OrderItems> Get(string guid)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<OrderItems>("SELECT cart_guid, product_id, product_name, product_description, SUM(product_qty) AS qty, product_price, SUM(product_price) AS price FROM cart_items LEFT JOIN products ON cart_items.product_id = products.id WHERE cart_guid = @guid GROUP BY product_id", new { guid }).ToList();
            }
        }

        public void Add(OrderItems orderItems)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO order_items (order_guid) VALUES (@order_guid)", orderItems);
            }
        }

    }
}