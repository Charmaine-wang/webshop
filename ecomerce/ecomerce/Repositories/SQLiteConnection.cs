using System;

namespace ecomerce.Repositories
{
    internal class SQLiteConnection : IDisposable
    {
        private string connectionString;

        public SQLiteConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal object Query<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
}