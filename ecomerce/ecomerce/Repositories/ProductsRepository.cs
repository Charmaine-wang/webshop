using System;
using System.Collections.Generic;
using ecomerce.Models;
using System.Data.SQLite;
using Dapper;
using System.Linq;



namespace ecomerce.Repositories
{
    public class ProductsRepository
    {

        private readonly string connectionString;

        public ProductsRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<Products> Get()
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<Products>("SELECT * FROM products").ToList();
            }
        }

        public List<Products> Get(string key)
        {
            using (SQLiteConnection connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<Products>("SELECT * FROM products WHERE id = @key", new { key }).ToList();
            }
        }

        public Products Get(int id)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<Products>("SELECT * FROM products WHERE Id = @Id", new { id });
            }

        }
    }
}
