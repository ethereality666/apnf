using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace apnf
{
    class Connector
    {
        MySqlConnection MySqlConnection = new MySqlConnection("host=localhost;port=3306;username=aether;password=!Exc25125;database=apnf");

        public void OpenConnection()
        {
            if(MySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                MySqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(MySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlConnection.Clone();
            }
        }

        public MySqlConnection GetConection()
        {
            return MySqlConnection;
        }
    }
}
