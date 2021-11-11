
namespace CGV
{
	partial class CreateFilmGenre
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIDCatogory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescriptions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.dgvShowCategory = new System.Windows.Forms.DataGridView();
            this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CGV.Properties.Resources._438deee628412c42d519a0764534f3cf;
            this.pictureBox1.Location = new System.Drawing.Point(-29, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 543);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(633, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtIDCatogory
            // 
            this.txtIDCatogory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCatogory.Location = new System.Drawing.Point(630, 183);
            this.txtIDCatogory.Name = "txtIDCatogory";
            this.txtIDCatogory.Size = new System.Drawing.Size(230, 30);
            this.txtIDCatogory.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Thể Loại";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(910, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 37);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(910, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 37);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptions.Location = new System.Drawing.Point(633, 366);
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(232, 30);
            this.txtDescriptions.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên thể loại";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(631, 278);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(230, 30);
            this.txtCategoryName.TabIndex = 15;
            // 
            // dgvShowCategory
            // 
            this.dgvShowCategory.AllowUserToAddRows = false;
            this.dgvShowCategory.AllowUserToDeleteRows = false;
            this.dgvShowCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCategory,
            this.CategoryName,
            this.Descriptions});
            this.dgvShowCategory.Location = new System.Drawing.Point(29, 31);
            this.dgvShowCategory.Name = "dgvShowCategory";
            this.dgvShowCategory.ReadOnly = true;
            this.dgvShowCategory.RowHeadersWidth = 51;
            this.dgvShowCategory.RowTemplate.Height = 24;
            this.dgvShowCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowCategory.Size = new System.Drawing.Size(539, 450);
            this.dgvShowCategory.TabIndex = 14;
            this.dgvShowCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowCategory_CellClick);
            // 
            // IDCategory
            // 
            this.IDCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCategory.HeaderText = "Id thể loại";
            this.IDCategory.MinimumWidth = 6;
            this.IDCategory.Name = "IDCategory";
            this.IDCategory.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.HeaderText = "Tên thể loại";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Descriptions
            // 
            this.Descriptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descriptions.HeaderText = "Mô tả";
            this.Descriptions.MinimumWidth = 6;
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(728, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thể loại phim";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(906, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // CreateFilmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIDCatogory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDescriptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.dgvShowCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateFilmGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateFilmGenre";
            this.Load += new System.EventHandler(this.CreateFilmGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDCatogory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDescriptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.DataGridView dgvShowCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}