
namespace CGV
{
    partial class BaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.idve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShowtime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idve,
            this.loaive,
            this.idlc,
            this.maghe,
            this.makh,
            this.trangthai,
            this.tien});
            this.dgvTicket.Location = new System.Drawing.Point(107, 200);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(1012, 372);
            this.dgvTicket.TabIndex = 1;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            this.dgvTicket.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellValueChanged);
            // 
            // idve
            // 
            this.idve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idve.HeaderText = "Mã Vé";
            this.idve.MinimumWidth = 6;
            this.idve.Name = "idve";
            this.idve.ReadOnly = true;
            // 
            // loaive
            // 
            this.loaive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaive.HeaderText = "Loại Vé";
            this.loaive.MinimumWidth = 6;
            this.loaive.Name = "loaive";
            this.loaive.ReadOnly = true;
            // 
            // idlc
            // 
            this.idlc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.idlc.DefaultCellStyle = dataGridViewCellStyle1;
            this.idlc.HeaderText = "Thời Gian Chiếu ";
            this.idlc.MinimumWidth = 6;
            this.idlc.Name = "idlc";
            this.idlc.ReadOnly = true;
            // 
            // maghe
            // 
            this.maghe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maghe.HeaderText = "Ghế";
            this.maghe.MinimumWidth = 6;
            this.maghe.Name = "maghe";
            this.maghe.ReadOnly = true;
            // 
            // makh
            // 
            this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // tien
            // 
            this.tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tien.HeaderText = "Giá Vé";
            this.tien.MinimumWidth = 6;
            this.tien.Name = "tien";
            this.tien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doanh Thu";
            // 
            // cmbShowtime
            // 
            this.cmbShowtime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShowtime.FormattingEnabled = true;
            this.cmbShowtime.Location = new System.Drawing.Point(141, 96);
            this.cmbShowtime.Name = "cmbShowtime";
            this.cmbShowtime.Size = new System.Drawing.Size(199, 31);
            this.cmbShowtime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(168, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "( Mã Lịch Chiếu)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(371, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "( Thời Gian Chiếu)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(311, 590);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(311, 628);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(968, 584);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 28);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(135, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tổng số VÉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(135, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng VÉ đã BÁN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(787, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng Tiền bán VÉ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1042, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(580, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "Báo Cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CGV.Properties.Resources._163074712011441713797;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 675);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 666);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbShowtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShowtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idve;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaive;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}