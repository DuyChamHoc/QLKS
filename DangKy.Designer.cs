
namespace QLKSNew
{
    partial class DangKy
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
            this.tbxidnhanvien = new System.Windows.Forms.TextBox();
            this.idnhanvien = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btntieptuc = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxidnhanvien
            // 
            this.tbxidnhanvien.Location = new System.Drawing.Point(472, 240);
            this.tbxidnhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.tbxidnhanvien.Name = "tbxidnhanvien";
            this.tbxidnhanvien.Size = new System.Drawing.Size(134, 21);
            this.tbxidnhanvien.TabIndex = 23;
            this.tbxidnhanvien.TextChanged += new System.EventHandler(this.tbxidnhanvien_TextChanged);
            // 
            // idnhanvien
            // 
            this.idnhanvien.AutoSize = true;
            this.idnhanvien.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnhanvien.Location = new System.Drawing.Point(349, 245);
            this.idnhanvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idnhanvien.Name = "idnhanvien";
            this.idnhanvien.Size = new System.Drawing.Size(104, 16);
            this.idnhanvien.TabIndex = 22;
            this.idnhanvien.Text = "ID Nhân Viên";
            this.idnhanvien.Click += new System.EventHandler(this.idnhanvien_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(472, 184);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(134, 21);
            this.password.TabIndex = 21;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(472, 127);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 21);
            this.username.TabIndex = 19;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tài Khoản";
            // 
            // btnhuy
            // 
            this.btnhuy.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Appearance.Options.UseFont = true;
            this.btnhuy.Location = new System.Drawing.Point(352, 300);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(115, 43);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.Appearance.Options.UseFont = true;
            this.btntieptuc.Location = new System.Drawing.Point(494, 300);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(112, 43);
            this.btntieptuc.TabIndex = 25;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 387);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKSNew.Properties.Resources._8b167af653c2399dd93b952a48740620;
            this.pictureBox1.Location = new System.Drawing.Point(47, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản đăng kí";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.tbxidnhanvien);
            this.Controls.Add(this.idnhanvien);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangKy_FormClosed);
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxidnhanvien;
        private System.Windows.Forms.Label idnhanvien;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btntieptuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}