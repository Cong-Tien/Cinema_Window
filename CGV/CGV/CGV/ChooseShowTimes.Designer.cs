
namespace CGV
{
    partial class ChooseShowTimes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowTime = new System.Windows.Forms.DataGridView();
            this.idlc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.cmbShowTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dgvShowTime);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 666);
            this.panel1.TabIndex = 3;
            // 
            // dgvShowTime
            // 
            this.dgvShowTime.AllowUserToAddRows = false;
            this.dgvShowTime.AllowUserToDeleteRows = false;
            this.dgvShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlc,
            this.idpc,
            this.phim,
            this.thoigian,
            this.tinhtrang});
            this.dgvShowTime.Location = new System.Drawing.Point(474, 124);
            this.dgvShowTime.Name = "dgvShowTime";
            this.dgvShowTime.ReadOnly = true;
            this.dgvShowTime.RowHeadersWidth = 51;
            this.dgvShowTime.RowTemplate.Height = 24;
            this.dgvShowTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowTime.Size = new System.Drawing.Size(771, 521);
            this.dgvShowTime.TabIndex = 4;
            this.dgvShowTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTime_CellClick);
            this.dgvShowTime.DoubleClick += new System.EventHandler(this.dgvShowTime_DoubleClick);
            // 
            // idlc
            // 
            this.idlc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idlc.HeaderText = "ShowTimeID";
            this.idlc.MinimumWidth = 6;
            this.idlc.Name = "idlc";
            this.idlc.ReadOnly = true;
            // 
            // idpc
            // 
            this.idpc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idpc.HeaderText = "Room";
            this.idpc.MinimumWidth = 6;
            this.idpc.Name = "idpc";
            this.idpc.ReadOnly = true;
            // 
            // phim
            // 
            this.phim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phim.HeaderText = "Movie";
            this.phim.MinimumWidth = 6;
            this.phim.Name = "phim";
            this.phim.ReadOnly = true;
            // 
            // thoigian
            // 
            this.thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.thoigian.DefaultCellStyle = dataGridViewCellStyle2;
            this.thoigian.HeaderText = "Moive ShowTime";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhtrang.HeaderText = "Status";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbRoom);
            this.groupBox1.Controls.Add(this.cmbMovie);
            this.groupBox1.Controls.Add(this.cmbShowTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpShowTime);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 421);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(145, 146);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(241, 28);
            this.cmbRoom.TabIndex = 7;
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(145, 88);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(241, 28);
            this.cmbMovie.TabIndex = 7;
            // 
            // cmbShowTime
            // 
            this.cmbShowTime.FormattingEnabled = true;
            this.cmbShowTime.Location = new System.Drawing.Point(145, 38);
            this.cmbShowTime.Name = "cmbShowTime";
            this.cmbShowTime.Size = new System.Drawing.Size(247, 28);
            this.cmbShowTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ShowTimesID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Movie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ShowTimes:";
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.CustomFormat = "dd/MM/yyyy";
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShowTime.Location = new System.Drawing.Point(145, 210);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.Size = new System.Drawing.Size(242, 28);
            this.dtpShowTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(467, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "ShowTimes";
            // 
            // ChooseShowTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 655);
            this.Controls.Add(this.panel1);
            this.Name = "ChooseShowTimes";
            this.Text = "Choose ShowTimes";
            this.Load += new System.EventHandler(this.ChooseShowTimes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpShowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbShowTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phim;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}