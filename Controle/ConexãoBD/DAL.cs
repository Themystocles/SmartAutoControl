using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.ConexãoBD
{
    public class DAL
    {
        private static string server = "localhost";
        private static string database = "controleserviços";
        private static string user = "root";
        private static string password = "";
        private static string connectionString = $"server = {server}; database ={database}; uid = {user}; pwd={password}";
        private MySqlConnection  connection;



        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }


        //EXECUTA SELECTs
        public DataTable RetdataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;

        }
        // INSERTTS, UPDATES, DELETES 
        public void ExecutaComandosSQL(string sql )
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();


        }
    }

   
}
