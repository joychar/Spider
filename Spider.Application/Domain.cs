using MySql.Data.MySqlClient;
using Spider.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Application
{
    public class Domain
    {

        public int InsertDomain(string domain,string name)
        {
            string sql = "INSERT domain (domain,name) VALUES(@domain,@name)";
            MySqlParameter[] paras = new MySqlParameter[]
            {
                new MySqlParameter("@domain",domain),
                new MySqlParameter("@name",name)
            };
            return DBHelper.ExecuteNonQuery(sql,paras);
        }
    }
}
