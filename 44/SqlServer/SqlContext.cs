using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.SqlServer
{
    public class SqlContext
    {
        public SqlContext(SqlConnection sqlConnection, SqlTransaction sqlTransaction)
        {
            this.Connection = sqlConnection;
            this.Transaction = sqlTransaction;
        }

        public SqlConnection Connection { get;  }
        public SqlTransaction Transaction { get; } 
    }
}
