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

    public class CartRepository
    {
        private readonly string connectionString;

        public CartRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<Cart> Get()
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<Cart>("SELECT * FROM cart_customer").ToList();
            }
        }

        public Cart Get(int id)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<Cart>("SELECT * FROM cart_customer WHERE Id = @Id", new { id });
            }

        }
    }
}
