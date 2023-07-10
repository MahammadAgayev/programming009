using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Options
{
    public class DbOptions
    {
        public const string SqlServerType = "sqlserver";
        public const string OracleType = "oracle";  

        public string Hostname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }    
        public bool WindowsAuthentication { get; set; }
        public string DatabaseName { get; set; }
        public string DbType { get; set; }
    }
}
