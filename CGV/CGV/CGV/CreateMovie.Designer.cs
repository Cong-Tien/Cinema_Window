
namespace CGV
{
	partial class CreateMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.picturePoster = new System.Windows.Forms.PictureBox();
            this.Poster = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.txtProductionYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPremiereDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewMovies = new System.Windows.Forms.DataGridView();
            this.colIdMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPremiereDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoster = new System.Windows.Forms.DataGridViewImageColumn();
            this.listboxCategory = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phim";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(76, 11);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.ReadOnly = true;
            this.txtMovieId.Size = new System.Drawing.Size(173, 20);
            this.txtMovieId.TabIndex = 0;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(76, 45);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(173, 20);
            this.txtMovieName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(76, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(173, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thể loại";
            // 
            // txtProductor
            // 
            this.txtProductor.Location = new System.Drawing.Point(406, 81);
            this.txtProductor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductor.Name = "txtProductor";
            this.txtProductor.Size = new System.Drawing.Size(173, 20);
            this.txtProductor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày công chiếu";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(406, 11);
            this.txtTotalTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(173, 20);
            this.txtTotalTime.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thời lượng";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(406, 119);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(173, 20);
            this.txtDirector.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đạo diễn";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 227);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(373, 227);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 32);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(442, 226);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(64, 32);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // picturePoster
            // 
            this.picturePoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePoster.Location = new System.Drawing.Point(612, 31);
            this.picturePoster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturePoster.Name = "picturePoster";
            this.picturePoster.Size = new System.Drawing.Size(190, 179);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoster.TabIndex = 19;
            this.picturePoster.TabStop = false;
            this.picturePoster.Click += new System.EventHandler(this.picturePoster_Click);
            // 
            // Poster
            // 
            this.Poster.AutoSize = true;
            this.Poster.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poster.Location = new System.Drawing.Point(688, 11);
            this.Poster.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(35, 17);
            this.Poster.TabIndex = 20;
            this.Poster.Text = "Ảnh";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(658, 214);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(100, 46);
            this.btnChooseImage.TabIndex = 21;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtProductionYear
            // 
            this.txtProductionYear.Location = new System.Drawing.Point(406, 158);
            this.txtProductionYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductionYear.Name = "txtProductionYear";
            this.txtProductionYear.Size = new System.Drawing.Size(173, 20);
            this.txtProductionYear.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Năm sản xuất";
            // 
            // dtpPremiereDate
            // 
            this.dtpPremiereDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPremiereDate.Location = new System.Drawing.Point(406, 45);
            this.dtpPremiereDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPremiereDate.Name = "dtpPremiereDate";
            this.dtpPremiereDate.Size = new System.Drawing.Size(172, 20);
            this.dtpPremiereDate.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewMovies);
            this.groupBox1.Location = new System.Drawing.Point(13, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(812, 279);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phim";
            // 
            // gridViewMovies
            // 
            this.gridViewMovies.AllowUserToAddRows = false;
            this.gridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMovie,
            this.colName,
            this.colDescription,
            this.colTotalTime,
            this.colPremiereDate,
            this.colProductor,
            this.colDirector,
            this.colProductionYear,
            this.colPoster});
            this.gridViewMovies.Location = new System.Drawing.Point(5, 18);
            this.gridViewMovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewMovies.Name = "gridViewMovies";
            this.gridViewMovies.ReadOnly = true;
            this.gridViewMovies.RowHeadersWidth = 51;
            this.gridViewMovies.RowTemplate.Height = 24;
            this.gridViewMovies.Size = new System.Drawing.Size(802, 256);
            this.gridViewMovies.TabIndex = 0;
            this.gridViewMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMovies_CellClick);
            // 
            // colIdMovie
            // 
            this.colIdMovie.HeaderText = "Mã phim";
            this.colIdMovie.MinimumWidth = 6;
            this.colIdMovie.Name = "colIdMovie";
            this.colIdMovie.ReadOnly = true;
            this.colIdMovie.Width = 125;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên phim";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 125;
            // 
            // colTotalTime
            // 
            this.colTotalTime.HeaderText = "Thời lượng phim";
            this.colTotalTime.MinimumWidth = 6;
            this.colTotalTime.Name = "colTotalTime";
            this.colTotalTime.ReadOnly = true;
            this.colTotalTime.Width = 140;
            // 
            // colPremiereDate
            // 
            this.colPremiereDate.HeaderText = "Ngày công chiếu";
            this.colPremiereDate.MinimumWidth = 6;
            this.colPremiereDate.Name = "colPremiereDate";
            this.colPremiereDate.ReadOnly = true;
            this.colPremiereDate.Width = 150;
            // 
            // colProductor
            // 
            this.colProductor.HeaderText = "Nhà sản xuất";
            this.colProductor.MinimumWidth = 6;
            this.colProductor.Name = "colProductor";
            this.colProductor.ReadOnly = true;
            this.colProductor.Width = 125;
            // 
            // colDirector
            // 
            this.colDirector.HeaderText = "Đạo diễn";
            this.colDirector.MinimumWidth = 6;
            this.colDirector.Name = "colDirector";
            this.colDirector.ReadOnly = true;
            this.colDirector.Width = 125;
            // 
            // colProductionYear
            // 
            this.colProductionYear.HeaderText = "Năm sản xuất";
            this.colProductionYear.MinimumWidth = 6;
            this.colProductionYear.Name = "colProductionYear";
            this.colProductionYear.ReadOnly = true;
            this.colProductionYear.Width = 125;
            // 
            // colPoster
            // 
            this.colPoster.HeaderText = "Ảnh";
            this.colPoster.MinimumWidth = 6;
            this.colPoster.Name = "colPoster";
            this.colPoster.ReadOnly = true;
            this.colPoster.Width = 125;
            // 
            // listboxCategory
            // 
            this.listboxCategory.FormattingEnabled = true;
            this.listboxCategory.Location = new System.Drawing.Point(13, 133);
            this.listboxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxCategory.Name = "listboxCategory";
            this.listboxCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listboxCategory.Size = new System.Drawing.Size(236, 134);
            this.listboxCategory.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(512, 227);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 32);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CreateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 554);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listboxCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpPremiereDate);
            this.Controls.Add(this.txtProductionYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.Poster);
            this.Controls.Add(this.picturePoster);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProductor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateMovie";
            this.Load += new System.EventHandler(this.CreateMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMovieId;
		private System.Windows.Forms.TextBox txtMovieName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTotalTime;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.PictureBox picturePoster;
		private System.Windows.Forms.Label Poster;
		private System.Windows.Forms.Button btnChooseImage;
		private System.Windows.Forms.TextBox txtProductionYear;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpPremiereDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView gridViewMovies;
		private System.Windows.Forms.ListBox listboxCategory;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdMovie;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotalTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPremiereDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDirector;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductionYear;
		private System.Windows.Forms.DataGridViewImageColumn colPoster;
	}
}