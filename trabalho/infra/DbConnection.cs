using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Geladeira.infra
{
    internal class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; private set; }

        public DbConnection()
        {
            var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Chapolin;Database=POO";
            Connection = new NpgsqlConnection(connectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
