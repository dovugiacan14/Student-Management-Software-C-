
namespace StudentManagement.Class
{
    partial class ClassList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.DataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.labelTenLop);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 151);
            this.panel1.TabIndex = 0;
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(241, 78);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(122, 33);
            this.buttonTim.TabIndex = 6;
            this.buttonTim.Text = "Tìm kiếm ";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(322, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(120, 20);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTenLop.Location = new System.Drawing.Point(192, 25);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(83, 22);
            this.labelTenLop.TabIndex = 0;
            this.labelTenLop.Text = "Tên lớp: ";
            // 
            // DataGridViewListStudent
            // 
            this.DataGridViewListStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewListStudent.Location = new System.Drawing.Point(8, 169);
            this.DataGridViewListStudent.Name = "DataGridViewListStudent";
            this.DataGridViewListStudent.Size = new System.Drawing.Size(657, 292);
            this.DataGridViewListStudent.TabIndex = 1;
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 473);
            this.Controls.Add(this.DataGridViewListStudent);
            this.Controls.Add(this.panel1);
            this.Name = "ClassList";
            this.Text = "ClassList";
            this.Load += new System.EventHandler(this.ClassList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.DataGridView DataGridViewListStudent;
        private System.Windows.Forms.Button buttonTim;
    }
}