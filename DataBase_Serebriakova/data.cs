using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Serebriakova
{
    class BD
    {
        MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=root;database=database");
        public void OpenCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public MySqlConnection getCon()
        {
            return con;
        }
    }

}
