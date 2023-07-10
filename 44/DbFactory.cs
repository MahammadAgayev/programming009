using _44.Domain.Abstract;
using _44.Options;
using _44.Oracle;
using _44.SqlServer;

using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace _44
{
    public static class DbFactory
    {
        public static IUnitOfWork Create(DbOptions options)
        {
            switch (options.DbType)
            {
                case DbOptions.OracleType:
                    return new OracleUnitOfWork();
                case DbOptions.SqlServerType:
                    return SqlServerUnitOfWork(options);
            }

            throw new ArgumentException("DbType not supported", options.DbType);
        }

        private static IUnitOfWork SqlServerUnitOfWork(DbOptions options)
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.DataSource = options.Hostname;
            sqlConnectionString.UserID = options.Username;
            sqlConnectionString.Password = options.Password;
            sqlConnectionString.InitialCatalog = options.DatabaseName;
            sqlConnectionString.IntegratedSecurity = options.WindowsAuthentication;

            return new SqlUnitOfWork(sqlConnectionString.ConnectionString);
        }
    }
}
