using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class CustomConnectionFactory : IDbConnectionFactory
    {
        public System.Data.Common.DbConnection CreateConnection(string nameOrConnectionString)
        {
            var name = nameOrConnectionString.Split('.').Last().Replace("Context", string.Empty);
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @".\SQLEXPRESS",
                InitialCatalog = name,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            };
            return new SqlConnection(builder.ToString());
        }
    }
}
