using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement.Class
{
    class ClassDetail
    {
       // public int MALOP { get; set; }
        public int MAKHOI { get; set; }
        public int SISO { get; set; }
        public string TENLOP { get; set; }
        public int MaxSiSo()
        {
            var maxAge = 40;
            SqlConnection connection = ConnectToSqlClass.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select GIATRI from THAMSO where TENTHAMSO = 'SiSoToiDa'", connection);
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                maxAge = Convert.ToInt32(da.GetValue(0).ToString());
            }
            return maxAge;
        }
        public void add_MultipleStatementsSingleInsert(IEnumerable<ClassDetail> entities)
        {
            using (var connection = ConnectToSqlClass.getConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into LOP(TENLOP,SISO,MAKHOI) values (@TENLOP, @SISO,@MAKHOI)";
                        //command.Parameters.Add("@MALOP", SqlDbType.Int);
                        command.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 40);
                        command.Parameters.Add("@SISO", SqlDbType.Int);
                        command.Parameters.Add("@MAKHOI", SqlDbType.Int);

                        try
                        {
                            foreach (var item in entities)
                            {
                               // command.Parameters["@MALOP"].Value = item.MALOP;
                                command.Parameters["@TENLOP"].Value = item.TENLOP;
                                command.Parameters["@SISO"].Value = item.SISO;
                                command.Parameters["@MAKHOI"].Value = item.MAKHOI;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            connection.Close();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
