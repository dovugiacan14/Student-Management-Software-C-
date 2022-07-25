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

namespace StudentManagement
{
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            //InitializeComponent();
            InitializeComponent1();
            LoadDataClass();
            //InitializeComponent1();
        }
        public void LoadDataClass()
        {
            var connect = ConnectToSqlClass.getConnection();
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select MALOP, TENLOP, SISO,TENKHOI, KHOI.MAKHOI from LOP, KHOI where LOP.MAKHOI = KHOI.MAKHOI order by MAKHOI", connect);
            DataTable dtClass = new DataTable();
            adapter.Fill(dtClass);
            DataGridViewClass.Rows.Clear();
            foreach (DataRow item in dtClass.Rows)
            {
                int n = DataGridViewClass.Rows.Add();
               // DataGridViewClass.Rows[n].Cells[0].Value = "false";
                DataGridViewClass.Rows[n].Cells[0].Value = item["MALOP"].ToString();
                DataGridViewClass.Rows[n].Cells[1].Value = item["TENLOP"].ToString();
                DataGridViewClass.Rows[n].Cells[2].Value = item["SISO"].ToString();
                DataGridViewClass.Rows[n].Cells[3].Value = item["TENKHOI"].ToString();
            }
            connect.Close();
        }
        private void InitializeComponent1()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.DataGridViewClass = new Bunifu.UI.WinForms.BunifuDataGridView();
           // this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThemLop = new System.Windows.Forms.Button();
            this.btXoaLop = new System.Windows.Forms.Button();
            this.btDoiTen = new System.Windows.Forms.Button();
            this.btXemLop = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClass)).BeginInit();
            this.SuspendLayout();
            //
            // DataGridViewClass
            //
            this.DataGridViewClass.AllowCustomTheming = true;
            this.DataGridViewClass.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewClass.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewClass.ColumnHeadersHeight = 40;
            this.DataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3, 
            this.Column4,});
            this.DataGridViewClass.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewClass.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewClass.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClass.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.DataGridViewClass.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewClass.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewClass.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.DataGridViewClass.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewClass.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewClass.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewClass.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            this.DataGridViewClass.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewClass.CurrentTheme.Name = null;
            this.DataGridViewClass.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewClass.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewClass.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewClass.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.DataGridViewClass.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewClass.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewClass.EnableHeadersVisualStyles = false;
            this.DataGridViewClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.DataGridViewClass.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewClass.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewClass.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewClass.Location = new System.Drawing.Point(-1, 60);
            this.DataGridViewClass.Name = "DataGridViewClass";
            this.DataGridViewClass.RowHeadersVisible = false;
            this.DataGridViewClass.RowHeadersWidth = 51;
            this.DataGridViewClass.RowTemplate.Height = 40;
            this.DataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClass.Size = new System.Drawing.Size(1209, 552);
            this.DataGridViewClass.TabIndex = 0;
            this.DataGridViewClass.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.DataGridViewClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClass_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên lớp ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sĩ số";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            //
            // Column 4
            //
            this.Column4.HeaderText = "Khối lớp ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column 4";
            //
            // Button_ThemLop
            //
            this.btThemLop.BackColor = System.Drawing.Color.DarkCyan;
            this.btThemLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btThemLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThemLop.FlatAppearance.BorderSize = 0;
            this.btThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemLop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemLop.ForeColor = System.Drawing.Color.White;
            this.btThemLop.Location = new System.Drawing.Point(24, 12);
            this.btThemLop.Name = "btThemLop";
            this.btThemLop.Size = new System.Drawing.Size(113, 45);
            this.btThemLop.TabIndex = 1;
            this.btThemLop.Text = "Thêm lớp";
            this.btThemLop.UseVisualStyleBackColor = false;
            this.btThemLop.Click += new System.EventHandler(this.btThemLop_Click);
            //
            // Button_XoaLop
            //
            this.btXoaLop.BackColor = System.Drawing.Color.DarkCyan;
            this.btXoaLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.BackgroundImage")));
            this.btXoaLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoaLop.FlatAppearance.BorderSize = 0;
            this.btXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaLop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaLop.ForeColor = System.Drawing.Color.White;
            this.btXoaLop.Location = new System.Drawing.Point(162,12 );
            this.btXoaLop.Name = "btXoaLop";
            this.btXoaLop.Size = new System.Drawing.Size(113, 45);
            this.btXoaLop.TabIndex = 2;
            this.btXoaLop.Text = "Xóa lớp";
            this.btXoaLop.UseVisualStyleBackColor = false;
            this.btXoaLop.Click += new System.EventHandler(this.button1_Click);
            //
            // Button_DoiTen
            //
            this.btDoiTen.BackColor = System.Drawing.Color.DarkCyan;
            this.btDoiTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoiTen.BackgroundImage")));
            this.btDoiTen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDoiTen.FlatAppearance.BorderSize = 0;
            this.btDoiTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoiTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTen.ForeColor = System.Drawing.Color.White;
            this.btDoiTen.Location = new System.Drawing.Point(314, 12);
            this.btDoiTen.Name = "btDoiTen";
            this.btDoiTen.Size = new System.Drawing.Size(128,45);
            this.btDoiTen.TabIndex = 3;
            this.btDoiTen.Text = "Thay đổi sĩ số tối đa";
            this.btDoiTen.UseVisualStyleBackColor = false;
            this.btDoiTen.Click += new System.EventHandler(this.btDoiTen_Click);
            //
            // Button_XemDanhSach
            //
            this.btXemLop.BackColor = System.Drawing.Color.DarkCyan;
            this.btXemLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemLop.BackgroundImage")));
            this.btXemLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXemLop.FlatAppearance.BorderSize = 0;
            this.btXemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXemLop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemLop.ForeColor = System.Drawing.Color.White;
            this.btXemLop.Location = new System.Drawing.Point(751, 12);
            this.btXemLop.Name = "btXemLop";
            this.btXemLop.Size = new System.Drawing.Size(113, 45);
            this.btXemLop.TabIndex = 4;
            this.btXemLop.Text = "Xem danh sách lớp";
            this.btXemLop.UseVisualStyleBackColor = false;
            this.btXemLop.Click += new System.EventHandler(this.btXemLop_Click);

            //
            // Button save
            //
            this.btSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemLop.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(500, 12);
            this.btSave.Name = "btsave";
            this.btSave.Size = new System.Drawing.Size(40, 40);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);

            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã lớp";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên lớp ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sĩ số";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Khối lớp";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // 
            // ClassForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 614);
            this.Controls.Add(this.btThemLop);
            this.Controls.Add(this.btXoaLop);
            this.Controls.Add(this.btDoiTen);
            this.Controls.Add(this.btXemLop);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.DataGridViewClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClass)).EndInit();
            this.ResumeLayout(false);
        }

        private void DataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btThemLop_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            ac.ShowDialog();
        }

        private void btDoiTen_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.ShowDialog();
        }

        private void btXemLop_Click(object sender, EventArgs e)
        {
            ClassList cl = new ClassList();
            cl.ShowDialog();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var con = ConnectToSqlClass.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("update LOP set TENLOP = @TENLOP,SISO=@SISO where MALOP = @MALOP", con);
            command.Parameters.Add("@TENLOP", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@SISO", SqlDbType.NVarChar,5);
            //command.Parameters.Add("@MAKHOI", SqlDbType.NVarChar,5);
            command.Parameters.Add("@MALOP", SqlDbType.NChar, 8);
            foreach (DataGridViewRow item in DataGridViewClass.Rows)
            {
                command.Parameters["@TENLOP"].Value = Convert.ToString(item.Cells[1].Value);
                command.Parameters["@SISO"].Value = Convert.ToString(item.Cells[2].Value);
              //  command.Parameters["@MAKHOI"].Value = Convert.ToString(item.Cells[3].Value);
                command.Parameters["@MALOP"].Value = Convert.ToString(item.Cells[0].Value);
                command.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Cập nhật thành công...!");
            LoadDataClass();
        }
    }
}
