using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовик
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=bogdanln.beget.tech; port=3306; username=bogdanln_1; password=Vfndtq02032002! ;database=bogdanln_1");
        public void Openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

        }
        public void closeconnectoin()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
