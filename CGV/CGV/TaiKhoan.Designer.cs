
namespace CGV
{
    partial class TaiKhoan
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.btoback = new System.Windows.Forms.Button();
            this.cboloaitk = new System.Windows.Forms.ComboBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btodoimatkhau = new System.Windows.Forms.Button();
            this.btosua = new System.Windows.Forms.Button();
            this.btoxoa = new System.Windows.Forms.Button();
            this.btothem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgwqltk = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaitk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btotimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwqltk)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(187, 47);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(203, 26);
            this.txtmanv.TabIndex = 10;
            // 
            // btoback
            // 
            this.btoback.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoback.ForeColor = System.Drawing.Color.Red;
            this.btoback.Location = new System.Drawing.Point(963, 521);
            this.btoback.Margin = new System.Windows.Forms.Padding(4);
            this.btoback.Name = "btoback";
            this.btoback.Size = new System.Drawing.Size(100, 45);
            this.btoback.TabIndex = 23;
            this.btoback.Text = "Quay Lại";
            this.btoback.UseVisualStyleBackColor = true;
            this.btoback.Click += new System.EventHandler(this.btoback_Click_2);
            // 
            // cboloaitk
            // 
            this.cboloaitk.FormattingEnabled = true;
            this.cboloaitk.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboloaitk.Location = new System.Drawing.Point(187, 199);
            this.cboloaitk.Margin = new System.Windows.Forms.Padding(4);
            this.cboloaitk.Name = "cboloaitk";
            this.cboloaitk.Size = new System.Drawing.Size(203, 27);
            this.cboloaitk.TabIndex = 8;
            this.cboloaitk.SelectedIndexChanged += new System.EventHandler(this.cboloaitk_SelectedIndexChanged);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(187, 101);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(203, 26);
            this.txttennv.TabIndex = 7;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(187, 146);
            this.txttk.Margin = new System.Windows.Forms.Padding(4);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(203, 26);
            this.txttk.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên NV :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.btodoimatkhau);
            this.groupBox4.Controls.Add(this.btosua);
            this.groupBox4.Controls.Add(this.btoxoa);
            this.groupBox4.Controls.Add(this.btothem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(31, 334);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(459, 192);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hiển Thị Tất Cả";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btodoimatkhau
            // 
            this.btodoimatkhau.Location = new System.Drawing.Point(297, 122);
            this.btodoimatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.btodoimatkhau.Name = "btodoimatkhau";
            this.btodoimatkhau.Size = new System.Drawing.Size(136, 46);
            this.btodoimatkhau.TabIndex = 3;
            this.btodoimatkhau.Text = "Đổi Mật  Khẩu";
            this.btodoimatkhau.UseVisualStyleBackColor = true;
            this.btodoimatkhau.Click += new System.EventHandler(this.btodoimatkhau_Click);
            // 
            // btosua
            // 
            this.btosua.Location = new System.Drawing.Point(328, 48);
            this.btosua.Margin = new System.Windows.Forms.Padding(4);
            this.btosua.Name = "btosua";
            this.btosua.Size = new System.Drawing.Size(105, 46);
            this.btosua.TabIndex = 2;
            this.btosua.Text = "Sửa";
            this.btosua.UseVisualStyleBackColor = true;
            this.btosua.Click += new System.EventHandler(this.btosua_Click_1);
            // 
            // btoxoa
            // 
            this.btoxoa.Location = new System.Drawing.Point(169, 48);
            this.btoxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btoxoa.Name = "btoxoa";
            this.btoxoa.Size = new System.Drawing.Size(105, 46);
            this.btoxoa.TabIndex = 1;
            this.btoxoa.Text = "Xóa";
            this.btoxoa.UseVisualStyleBackColor = true;
            this.btoxoa.Click += new System.EventHandler(this.btoxoa_Click_1);
            // 
            // btothem
            // 
            this.btothem.Location = new System.Drawing.Point(8, 48);
            this.btothem.Margin = new System.Windows.Forms.Padding(4);
            this.btothem.Name = "btothem";
            this.btothem.Size = new System.Drawing.Size(105, 46);
            this.btothem.TabIndex = 0;
            this.btothem.Text = "Thêm";
            this.btothem.UseVisualStyleBackColor = true;
            this.btothem.Click += new System.EventHandler(this.btothem_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại TK :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tài Khoản :";
            // 
            // dtgwqltk
            // 
            this.dtgwqltk.AllowUserToDeleteRows = false;
            this.dtgwqltk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwqltk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.TenNV,
            this.taikhoan1,
            this.Loaitk});
            this.dtgwqltk.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgwqltk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwqltk.Location = new System.Drawing.Point(4, 23);
            this.dtgwqltk.Margin = new System.Windows.Forms.Padding(4);
            this.dtgwqltk.Name = "dtgwqltk";
            this.dtgwqltk.ReadOnly = true;
            this.dtgwqltk.RowHeadersWidth = 51;
            this.dtgwqltk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgwqltk.Size = new System.Drawing.Size(619, 341);
            this.dtgwqltk.TabIndex = 0;
            this.dtgwqltk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwqltk_CellContentClick);
            this.dtgwqltk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwqltk_CellContentClick);
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.HeaderText = "Mã NV";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // taikhoan1
            // 
            this.taikhoan1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taikhoan1.HeaderText = "Tài Khoản";
            this.taikhoan1.MinimumWidth = 6;
            this.taikhoan1.Name = "taikhoan1";
            this.taikhoan1.ReadOnly = true;
            // 
            // Loaitk
            // 
            this.Loaitk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loaitk.HeaderText = "Loại TK";
            this.Loaitk.MinimumWidth = 6;
            this.Loaitk.Name = "Loaitk";
            this.Loaitk.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btotimkiem);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(498, 63);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(489, 74);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btotimkiem
            // 
            this.btotimkiem.Location = new System.Drawing.Point(296, 34);
            this.btotimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btotimkiem.Name = "btotimkiem";
            this.btotimkiem.Size = new System.Drawing.Size(100, 27);
            this.btotimkiem.TabIndex = 2;
            this.btotimkiem.Text = "Tìm Kiếm";
            this.btotimkiem.UseVisualStyleBackColor = true;
            this.btotimkiem.Click += new System.EventHandler(this.btotimkiem_Click_1);
            // 
            // txttimkiem
            // 
            this.txttimkiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txttimkiem.Location = new System.Drawing.Point(8, 34);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(244, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Text = "Nhập Tên Nhân Viên";
            this.txttimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txttimkiem.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgwqltk);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(498, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(627, 368);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã NV :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(351, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quản Lý Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmanv);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboloaitk);
            this.groupBox2.Controls.Add(this.txttennv);
            this.groupBox2.Controls.Add(this.txttk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(403, 263);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGV.Properties.Resources.wp2885694;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 571);
            this.Controls.Add(this.btoback);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwqltk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button btoback;
        private System.Windows.Forms.ComboBox cboloaitk;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btodoimatkhau;
        private System.Windows.Forms.Button btosua;
        private System.Windows.Forms.Button btoxoa;
        private System.Windows.Forms.Button btothem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgwqltk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btotimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaitk;
    }
}