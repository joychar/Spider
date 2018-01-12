using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Spider.Data
{
    public static class DBHelper
    {
        private static readonly string connectionStringPort = "Database=lqc_spider;Data Source=59647813aaa48.sh.cdb.myqcloud.com;User Id=root;Password=JinxQ007008;pooling=false;CharSet=utf8;port=15955";

        public static int ExecuteNonQuery(string sql,params MySqlParameter[] paras)
        {
            return MySqlHelper.ExecuteNonQuery(connectionStringPort, sql, paras);
        }

        public static DataSet Excute(string sql)
        {
            return MySqlHelper.ExecuteDataset(connectionStringPort, sql);
        }

        public static bool ExecuteNonQueryTrans(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionStringPort))
            {
                conn.Open();

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
