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
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
            LoadClassList();
        }
        

        private void buttonThemLop_Click(object sender, EventArgs e)
        {

        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            
            
        }
        public void LoadClassList()
        {
            
            string query = "select HO, TEN, GIOITINH, NGSINH, DIACHI ,TENLOP FROM HOCSINH HS, QUATRINHHOC QTH,LOP WHERE HS.MAHS = QTH.MAHS AND QTH.MALOP = LOP.MALOP ";
            DataProvider provider = new DataProvider();
            DataGridViewListStudent.DataSource = provider.ExcuteQuery(query);


        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            DataGridViewListStudent.DataSource = SearchClassByName(txtTimKiem.Text);

        }
        List<ClassInfoDTO> SearchClassByName(string name)
        {
            List<ClassInfoDTO> ListClass = ClassInfoDAO.Instance.getClassbyName(name);
            return ListClass;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
