using System;
using System.Collections.Generic;
using ecommerce.Models;
using System.Data.SQLite;
using Dapper;
using System.Linq;


namespace ecommerce.Repositories
{
    public class CustomerRepository
    {

        private readonly string connectionString;

        public CustomerRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<Customer> Get()
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.Query<Customer>("SELECT * FROM customer").ToList();
            }
        }


        public Customer Get(string guid)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<Customer>("SELECT * FROM customer WHERE customer_guid = @guid", new { guid });
            }

        }

        public void Add(Customer customer)
        {
            using (var connection = new SQLiteConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO customer (customer_guid, customer_name, customer_adress) VALUES (@customer_guid, @customer_name, @customer_adress)", customer);
            }
        }
    }
}

