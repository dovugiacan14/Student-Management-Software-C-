using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;  

namespace StudentManagement.Class
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return  DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        //private DataProvider();

        private string connectSTR = "Data Source=(local);database = QLHS;Integrated Security=True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable dtClassList = new DataTable();
            using(SqlConnection connect = new SqlConnection(connectSTR))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtClassList);
                connect.Close();
            }    
            return dtClassList; 
           //DataGridViewListStudent.DataSource = dtClassList;
        }
    }
}
