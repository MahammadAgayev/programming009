using _45.Domain.Abstract;
using _45.SqlServer;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    public class DbFactory
    {
        private static IUnitOfWork _unitOfWork;

        public static IUnitOfWork GetUnitOfWork()
        {
            if(_unitOfWork == null)
            {
               SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.InitialCatalog = "programming009";
                builder.IntegratedSecurity = true;
                builder.DataSource = ".";

                _unitOfWork = new SqlUnitOfWork(builder.ConnectionString);
            }

            return _unitOfWork;
        }
    }
}
