using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace QrAguas.Controls
{
    class Connection
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["QrAguasAwsDB"].ConnectionString;


        public MySqlConnection AbrirBanco()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                return connection;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void FecharBanco(MySqlConnection connection)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
