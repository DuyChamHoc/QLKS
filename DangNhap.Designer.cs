
namespace QLKSNew
{
    partial class DangNhap
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
            DevExpress.Sparkline.LineSparklineView lineSparklineView3 = new DevExpress.Sparkline.LineSparklineView();
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sparklineEdit1 = new DevExpress.XtraEditors.SparklineEdit();
            this.sparklineEdit2 = new DevExpress.XtraEditors.SparklineEdit();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btndangki = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(386, 151);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(476, 20);
            this.password.TabIndex = 5;
            this.password.Text = "PASSWORD";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(386, 102);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(476, 20);
            this.username.TabIndex = 4;
            this.username.Text = "USERNAME";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 381);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKSNew.Properties.Resources.illust58_5847_01;
            this.pictureBox1.Location = new System.Drawing.Point(56, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(439, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(244, 32);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Quản lý khách sạn";
            // 
            // sparklineEdit1
            // 
            this.sparklineEdit1.Location = new System.Drawing.Point(386, 130);
            this.sparklineEdit1.Name = "sparklineEdit1";
            this.sparklineEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.sparklineEdit1.Properties.Appearance.Options.UseBackColor = true;
            lineSparklineView3.ScaleFactor = 1F;
            this.sparklineEdit1.Properties.View = lineSparklineView3;
            this.sparklineEdit1.Size = new System.Drawing.Size(476, 1);
            this.sparklineEdit1.TabIndex = 0;
            this.sparklineEdit1.EditValueChanged += new System.EventHandler(this.sparklineEdit1_EditValueChanged_1);
            // 
            // sparklineEdit2
            // 
            this.sparklineEdit2.Location = new System.Drawing.Point(386, 180);
            this.sparklineEdit2.Name = "sparklineEdit2";
            this.sparklineEdit2.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.sparklineEdit2.Properties.Appearance.Options.UseBackColor = true;
            lineSparklineView1.ScaleFactor = 1F;
            this.sparklineEdit2.Properties.View = lineSparklineView1;
            this.sparklineEdit2.Size = new System.Drawing.Size(476, 1);
            this.sparklineEdit2.TabIndex = 10;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btndangnhap.FlatAppearance.BorderSize = 0;
            this.btndangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.LightGray;
            this.btndangnhap.Location = new System.Drawing.Point(386, 205);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(476, 46);
            this.btndangnhap.TabIndex = 0;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btndangki
            // 
            this.btndangki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btndangki.FlatAppearance.BorderSize = 0;
            this.btndangki.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btndangki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangki.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangki.ForeColor = System.Drawing.Color.LightGray;
            this.btndangki.Location = new System.Drawing.Point(386, 276);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(476, 46);
            this.btndangki.TabIndex = 11;
            this.btndangki.Text = "Đăng ký";
            this.btndangki.UseVisualStyleBackColor = false;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // DangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 381);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.sparklineEdit2);
            this.Controls.Add(this.sparklineEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DangNhap";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklineEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SparklineEdit sparklineEdit1;
        private DevExpress.XtraEditors.SparklineEdit sparklineEdit2;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

