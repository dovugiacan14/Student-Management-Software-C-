using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Semester;
using StudentManagement.Subject;

namespace StudentManagement
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            LoadData();
            AbrirFormInPanel(new StudentForm());
        }

        private void LoadData()
        {
            gunaButton1.Text = "Quản lý" + Environment.NewLine + "học sinh";
            gunaButton1.TextAlign = HorizontalAlignment.Left;
            gunaButton2.Text = "Quản lý" + Environment.NewLine + "lớp học";
            gunaButton2.TextAlign = HorizontalAlignment.Left;
            gunaButton3.Text = "Báo cáo" + Environment.NewLine + "thống kê"; 
            gunaButton3.TextAlign = HorizontalAlignment.Left;
            gunaButton4.Text = "Quản lý" + Environment.NewLine + "điểm";
            gunaButton4.TextAlign = HorizontalAlignment.Left;
            gunaButton5.Text = "Quản lý" + Environment.NewLine + "môn học";
            gunaButton5.TextAlign = HorizontalAlignment.Left;
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new StudentForm());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ClassForm());
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new SemesterForm());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ScoreSubjectForm());
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CTHForm());
        }
    }
}
