
namespace CGV
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvShowTime = new System.Windows.Forms.DataGridView();
            this.cmbMoive = new System.Windows.Forms.ComboBox();
            this.btnMoive = new System.Windows.Forms.Label();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giochieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CGV.Properties.Resources._163074712011441713797;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 633);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 598);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgvShowTime
            // 
            this.dgvShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphim,
            this.ngaychieu,
            this.giochieu,
            this.sove,
            this.tienve});
            this.dgvShowTime.Location = new System.Drawing.Point(146, 190);
            this.dgvShowTime.Name = "dgvShowTime";
            this.dgvShowTime.RowHeadersWidth = 51;
            this.dgvShowTime.RowTemplate.Height = 24;
            this.dgvShowTime.Size = new System.Drawing.Size(802, 371);
            this.dgvShowTime.TabIndex = 2;
            // 
            // cmbMoive
            // 
            this.cmbMoive.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoive.FormattingEnabled = true;
            this.cmbMoive.Location = new System.Drawing.Point(382, 66);
            this.cmbMoive.Name = "cmbMoive";
            this.cmbMoive.Size = new System.Drawing.Size(285, 28);
            this.cmbMoive.TabIndex = 3;
            // 
            // btnMoive
            // 
            this.btnMoive.AutoSize = true;
            this.btnMoive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMoive.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoive.Location = new System.Drawing.Point(258, 66);
            this.btnMoive.Name = "btnMoive";
            this.btnMoive.Size = new System.Drawing.Size(101, 22);
            this.btnMoive.TabIndex = 4;
            this.btnMoive.Text = "Chọn Phim";
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.CustomFormat = "dd/MM/yyyy";
            this.dtpShowTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowTime.Location = new System.Drawing.Point(262, 100);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.Size = new System.Drawing.Size(220, 28);
            this.dtpShowTime.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(611, 118);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(109, 37);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(746, 118);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(109, 37);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(469, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOANH THU";
            // 
            // tenphim
            // 
            this.tenphim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphim.HeaderText = "Tên Phim";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            // 
            // ngaychieu
            // 
            this.ngaychieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            this.ngaychieu.DefaultCellStyle = dataGridViewCellStyle7;
            this.ngaychieu.HeaderText = "Ngày Chiếu";
            this.ngaychieu.MinimumWidth = 6;
            this.ngaychieu.Name = "ngaychieu";
            // 
            // giochieu
            // 
            this.giochieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "T";
            dataGridViewCellStyle8.NullValue = null;
            this.giochieu.DefaultCellStyle = dataGridViewCellStyle8;
            this.giochieu.HeaderText = "Giờ Chiếu";
            this.giochieu.MinimumWidth = 6;
            this.giochieu.Name = "giochieu";
            // 
            // sove
            // 
            this.sove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sove.HeaderText = "Số Vé Đã Bán";
            this.sove.MinimumWidth = 6;
            this.sove.Name = "sove";
            // 
            // tienve
            // 
            this.tienve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tienve.HeaderText = "Tiền Vé";
            this.tienve.MinimumWidth = 6;
            this.tienve.Name = "tienve";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(775, 581);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 28);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpShowTime);
            this.Controls.Add(this.btnMoive);
            this.Controls.Add(this.cmbMoive);
            this.Controls.Add(this.dgvShowTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giochieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sove;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienve;
        private System.Windows.Forms.ComboBox cmbMoive;
        private System.Windows.Forms.Label btnMoive;
        private System.Windows.Forms.DateTimePicker dtpShowTime;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}