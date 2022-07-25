
namespace StudentManagement
{
    partial class Setting
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
            this.lbSiSo = new System.Windows.Forms.Label();
            this.txbSet = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.lbSiSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSiSo.Location = new System.Drawing.Point(12, 25);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(86, 19);
            this.lbSiSo.TabIndex = 1;
            this.lbSiSo.Text = "Sĩ số tối đa ";
            // 
            // txbSet
            // 
            this.txbSet.Location = new System.Drawing.Point(104, 26);
            this.txbSet.Name = "txbSet";
            this.txbSet.Size = new System.Drawing.Size(100, 20);
            this.txbSet.TabIndex = 2;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.White;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLuu.Location = new System.Drawing.Point(78, 73);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(58, 33);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(228, 118);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txbSet);
            this.Controls.Add(this.lbSiSo);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.TextBox txbSet;
        private System.Windows.Forms.Button btLuu;
    }
}