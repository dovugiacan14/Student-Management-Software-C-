using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.Semester
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = ConnectToSqlSemester.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(@"update THAMSO set GIATRI = @Diem where TENTHAMSO = 'DiemDatHocKy'", connection);
            command.Parameters.AddWithValue("@Diem", int.Parse(bunifuTextBox1.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            connection.Close();
        }
    }
}
