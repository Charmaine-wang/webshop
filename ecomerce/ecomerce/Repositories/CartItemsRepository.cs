using System;
using System.Collections.Generic;
using ecomerce.Models;
using System.Data.SQLite;
using Dapper;
using System.Linq;

namespace ecomerce
{

    //public interface CartRepository
    //{
    //    List<Cart> Get(string userid);

    //    bool AddToCart(Cart cart);

    //    bool Delete(string userid, int productid);
    //}

    public class CartItemsRepository
    {
        private readonly string connectionString;

        public CartItemsRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<CartItems> Get()
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<CartItems>("SELECT * FROM cart_items").ToList();
            }
        }

        public CartItems Get(int id)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<CartItems>("SELECT * FROM cart_items WHERE Id = @Id", new { id });
            }

        }
    }
}
