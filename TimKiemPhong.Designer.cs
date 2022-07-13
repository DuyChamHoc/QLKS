
namespace QLKSNew
{
    partial class TimKiemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemPhong));
            this.lbtimphong = new System.Windows.Forms.Label();
            this.tbxtimphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvtimphong = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtimphong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtimphong
            // 
            this.lbtimphong.AutoSize = true;
            this.lbtimphong.Location = new System.Drawing.Point(491, 27);
            this.lbtimphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtimphong.Name = "lbtimphong";
            this.lbtimphong.Size = new System.Drawing.Size(0, 13);
            this.lbtimphong.TabIndex = 11;
            // 
            // tbxtimphong
            // 
            this.tbxtimphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtimphong.Location = new System.Drawing.Point(134, 24);
            this.tbxtimphong.Margin = new System.Windows.Forms.Padding(2);
            this.tbxtimphong.Name = "tbxtimphong";
            this.tbxtimphong.Size = new System.Drawing.Size(148, 26);
            this.tbxtimphong.TabIndex = 8;
            this.tbxtimphong.TextChanged += new System.EventHandler(this.tbxtimphong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Phòng";
            // 
            // dtgvtimphong
            // 
            this.dtgvtimphong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvtimphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtimphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvtimphong.Location = new System.Drawing.Point(0, 69);
            this.dtgvtimphong.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvtimphong.Name = "dtgvtimphong";
            this.dtgvtimphong.RowHeadersWidth = 51;
            this.dtgvtimphong.RowTemplate.Height = 24;
            this.dtgvtimphong.Size = new System.Drawing.Size(518, 387);
            this.dtgvtimphong.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(300, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 26);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Chọn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(394, 25);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(112, 26);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Kết thúc";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TimKiemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKSNew.Properties.Resources._5c01afda97f678cf801271eebb041ba6161;
            this.ClientSize = new System.Drawing.Size(518, 456);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lbtimphong);
            this.Controls.Add(this.tbxtimphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvtimphong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimKiemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemPhong";
            this.Load += new System.EventHandler(this.TimKiemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtimphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtimphong;
        private System.Windows.Forms.TextBox tbxtimphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvtimphong;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}