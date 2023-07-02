using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace фыввфывфывфыв
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SqlConnection Connection = new SqlConnection("server=PikaChu-PC\\PIKACHUSQL;Trusted_Connection=yes;database=Demo");
        public static DataTable Get(string Query)
        {
            try
            {
                DataTable dataTable = new DataTable("dataBase");
                Connection.Open();
                SqlCommand sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = Query;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                Connection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Connection.Close();
                MessageBox.Show("Ошибка " + ex.Message);
                return null;
            }
        }
    }
}
