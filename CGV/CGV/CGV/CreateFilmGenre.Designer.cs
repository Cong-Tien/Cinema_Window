
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvShowCategory = new System.Windows.Forms.DataGridView();
			this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescriptions = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIDCatogory = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvShowCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(887, 147);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(123, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(604, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 63);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thể loại phim";
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
			this.dgvShowCategory.Location = new System.Drawing.Point(-3, 1);
			this.dgvShowCategory.Name = "dgvShowCategory";
			this.dgvShowCategory.ReadOnly = true;
			this.dgvShowCategory.RowHeadersWidth = 51;
			this.dgvShowCategory.RowTemplate.Height = 24;
			this.dgvShowCategory.Size = new System.Drawing.Size(539, 450);
			this.dgvShowCategory.TabIndex = 2;
			this.dgvShowCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowCategory_CellClick);
			// 
			// IDCategory
			// 
			this.IDCategory.HeaderText = "Id thể loại";
			this.IDCategory.MinimumWidth = 6;
			this.IDCategory.Name = "IDCategory";
			this.IDCategory.ReadOnly = true;
			this.IDCategory.Width = 125;
			// 
			// CategoryName
			// 
			this.CategoryName.HeaderText = "Tên thể loại";
			this.CategoryName.MinimumWidth = 6;
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			this.CategoryName.Width = 125;
			// 
			// Descriptions
			// 
			this.Descriptions.HeaderText = "Mô tả";
			this.Descriptions.MinimumWidth = 6;
			this.Descriptions.Name = "Descriptions";
			this.Descriptions.ReadOnly = true;
			this.Descriptions.Width = 125;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(599, 248);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(230, 22);
			this.txtCategoryName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(594, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên thể loại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(596, 285);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mô tả";
			// 
			// txtDescriptions
			// 
			this.txtDescriptions.Location = new System.Drawing.Point(601, 337);
			this.txtDescriptions.Name = "txtDescriptions";
			this.txtDescriptions.Size = new System.Drawing.Size(232, 22);
			this.txtDescriptions.TabIndex = 6;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(891, 295);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(119, 37);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(891, 217);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(119, 37);
			this.btnEdit.TabIndex = 8;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(594, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 29);
			this.label4.TabIndex = 9;
			this.label4.Text = "Id Thể Loại";
			// 
			// txtIDCatogory
			// 
			this.txtIDCatogory.Location = new System.Drawing.Point(599, 156);
			this.txtIDCatogory.Name = "txtIDCatogory";
			this.txtIDCatogory.Size = new System.Drawing.Size(230, 22);
			this.txtIDCatogory.TabIndex = 10;
			// 
			// CreateFilmGenre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 539);
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
			this.Name = "CreateFilmGenre";
			this.Text = "CreateFilmGenre";
			this.Load += new System.EventHandler(this.CreateFilmGenre_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvShowCategory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvShowCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescriptions;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIDCatogory;
	}
}