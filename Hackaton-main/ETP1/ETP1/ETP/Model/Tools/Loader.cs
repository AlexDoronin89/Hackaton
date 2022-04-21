using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ETP.Model.Tools
{
    class Loader
    {
        private string _connectionStr = "Server=localhost;User=root;Password=1234;Database=test_sql_lesson;";
        private MySqlConnection _connection;

        public List<User> LoadUser()
        {

        }
    }
}
