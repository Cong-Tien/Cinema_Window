
namespace CGV
{
    partial class CreateTicket
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
            this.dgvShowTime = new System.Windows.Forms.DataGridView();
            this.malichchieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMalc = new System.Windows.Forms.TextBox();
            this.txtPhim = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idve,
            this.loaive,
            this.malc,
            this.maghe,
            this.gia,
            this.trangthai,
            this.makh});
            this.dgvTicket.Location = new System.Drawing.Point(6, 93);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(647, 562);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellValueChanged);
            // 
            // dgvShowTime
            // 
            this.dgvShowTime.AllowUserToAddRows = false;
            this.dgvShowTime.AllowUserToDeleteRows = false;
            this.dgvShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malichchieu,
            this.tenpc,
            this.tenphim,
            this.thoigian,
            this.tinhtrang});
            this.dgvShowTime.Location = new System.Drawing.Point(659, 93);
            this.dgvShowTime.Name = "dgvShowTime";
            this.dgvShowTime.ReadOnly = true;
            this.dgvShowTime.RowHeadersWidth = 51;
            this.dgvShowTime.RowTemplate.Height = 24;
            this.dgvShowTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowTime.Size = new System.Drawing.Size(586, 260);
            this.dgvShowTime.TabIndex = 2;
            this.dgvShowTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTime_CellClick);
            // 
            // malichchieu
            // 
            this.malichchieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malichchieu.HeaderText = "ShowTimesID";
            this.malichchieu.MinimumWidth = 6;
            this.malichchieu.Name = "malichchieu";
            this.malichchieu.ReadOnly = true;
            // 
            // tenpc
            // 
            this.tenpc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenpc.HeaderText = "Room";
            this.tenpc.MinimumWidth = 6;
            this.tenpc.Name = "tenpc";
            this.tenpc.ReadOnly = true;
            // 
            // tenphim
            // 
            this.tenphim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphim.HeaderText = "Movie";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            this.tenphim.ReadOnly = true;
            // 
            // thoigian
            // 
            this.thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.thoigian.DefaultCellStyle = dataGridViewCellStyle1;
            this.thoigian.HeaderText = "ShowTimes";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhtrang.HeaderText = "Condition";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            // 
            // txtMalc
            // 
            this.txtMalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalc.Location = new System.Drawing.Point(893, 377);
            this.txtMalc.Name = "txtMalc";
            this.txtMalc.Size = new System.Drawing.Size(256, 27);
            this.txtMalc.TabIndex = 3;
            // 
            // txtPhim
            // 
            this.txtPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhim.Location = new System.Drawing.Point(893, 430);
            this.txtPhim.Name = "txtPhim";
            this.txtPhim.Size = new System.Drawing.Size(256, 27);
            this.txtPhim.TabIndex = 3;
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(893, 476);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(256, 27);
            this.txtPhong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ShowTimesID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(893, 522);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(256, 27);
            this.txtTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "ShowTimes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(725, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 90);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(81, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create  Ticket";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(27, 28);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(118, 44);
            this.btnAddTicket.TabIndex = 1;
            this.btnAddTicket.Text = "Auto Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Sold Ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(295, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Remove  Tickets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAddTicket);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(459, 29);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(102, 42);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1088, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 666);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(554, 666);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 24);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 666);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng số Vé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(367, 666);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng số Vé Đã Bán";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // idve
            // 
            this.idve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idve.HeaderText = "ID Ticket";
            this.idve.MinimumWidth = 6;
            this.idve.Name = "idve";
            this.idve.ReadOnly = true;
            // 
            // loaive
            // 
            this.loaive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaive.HeaderText = "Type Ticket";
            this.loaive.MinimumWidth = 6;
            this.loaive.Name = "loaive";
            this.loaive.ReadOnly = true;
            // 
            // malc
            // 
            this.malc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malc.HeaderText = "ShowTimeID";
            this.malc.MinimumWidth = 6;
            this.malc.Name = "malc";
            this.malc.ReadOnly = true;
            // 
            // maghe
            // 
            this.maghe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maghe.HeaderText = "SeatName";
            this.maghe.MinimumWidth = 6;
            this.maghe.Name = "maghe";
            this.maghe.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.HeaderText = "Fare";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.HeaderText = "Status";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // makh
            // 
            this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makh.HeaderText = "KH Thành Viên";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 725);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtPhim);
            this.Controls.Add(this.txtMalc);
            this.Controls.Add(this.dgvShowTime);
            this.Controls.Add(this.dgvTicket);
            this.Name = "CreateTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Ticket";
            this.Load += new System.EventHandler(this.CreateTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.DataGridView dgvShowTime;
        private System.Windows.Forms.TextBox txtMalc;
        private System.Windows.Forms.TextBox txtPhim;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malichchieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idve;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaive;
        private System.Windows.Forms.DataGridViewTextBoxColumn malc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
    }
}

