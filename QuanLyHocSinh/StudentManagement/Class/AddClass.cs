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
using StudentManagement.Class;

namespace StudentManagement.Class
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            DataGridViewAddClass.AllowUserToAddRows = false;
            DataGridViewAddClass.Rows.Add();
        }

        private void AddMultiRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewAddClass.Rows.Add();
                DataGridViewAddClass.CurrentCell = DataGridViewAddClass.Rows[DataGridViewAddClass.Rows.Count - 1].Cells[0];
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ClassDetail detailModel = new ClassDetail();
            Boolean ValidSiSo = false;
            List<ClassDetail> objectDetailList = new List<ClassDetail>();
            foreach (DataGridViewRow dgvRow in DataGridViewAddClass.Rows)
            {
                var detail = new ClassDetail()
                {

                    //MALOP = Convert.ToInt32(dgvRow.Cells[0].Value),
                    TENLOP = Convert.ToString(dgvRow.Cells[0].Value),
                    SISO = Convert.ToInt32(dgvRow.Cells[1].Value),
                    MAKHOI = Convert.ToInt32(dgvRow.Cells[2].Value),
                    //            

                };   
                if(detail.SISO > detailModel.MaxSiSo())
                {
                    MessageBox.Show("Độ tuổi không hợp lệ");
                    ValidSiSo = true;
                }
                else
                {
                    objectDetailList.Add(detail);
                }
            }
            if(ValidSiSo == false)
            {
                detailModel = new ClassDetail();
                detailModel.add_MultipleStatementsSingleInsert(objectDetailList);
                MessageBox.Show("Thêm lớp thành công");
            } 
        }

        private void AddClass_KeyDown(object sender, KeyEventArgs e)
        {

        }
    } 
}
