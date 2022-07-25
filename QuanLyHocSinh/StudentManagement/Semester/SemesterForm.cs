using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagement.Semester;


namespace StudentManagement.Semester
{
    public partial class SemesterForm : Form
    {
        public SemesterForm()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            var con = ConnectToSqlSemester.getConnection();
            con.Open();
            SqlDataAdapter bc = new SqlDataAdapter("Select TENHOCKY,NAMHOC ,TENLOP,SISO, SOLUONGDAT, TILE from HOCKY, LOP, TONGKETHOCKY where TONGKETHOCKY.MAHK=HOCKY.MAHK and TONGKETHOCKY.MALOP=LOP.MALOP order by TENLOP", con);
            DataTable dtSemester = new DataTable();
            bc.Fill(dtSemester);
            dataGridView1.Rows.Clear();
                foreach (DataRow item in dtSemester.Rows)
                {
                int n = dataGridView1.Rows.Add();
                //dataGridViewSemester1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[0].Value = item["TENHOCKY"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["NAMHOC"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["TENLOP"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["SISO"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["SOLUONGDAT"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["TILE"].ToString();
                }
            con.Close();
        }


        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewSemester;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        
        private void Semester_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Setting Ssf = new Setting();
            Ssf.ShowDialog();
        }
    }
}
