using CGV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV
{
	public partial class CreateFilmGenre : Form
	{
		CGVDBContext Context;
		public CreateFilmGenre()
		{
			InitializeComponent();
			Context = new CGVDBContext();
		}

		private void CreateFilmGenre_Load(object sender, EventArgs e)
		{
			List<FilmGenre> filmGenres = Context.FilmGenres.ToList();
			LoadData(filmGenres);
		}
		private void LoadData(List<FilmGenre> filmGenres)
		{
			dgvShowCategory.Rows.Clear();
			foreach(var st in filmGenres)
			{
				int indexRow = dgvShowCategory.Rows.Add();
				dgvShowCategory.Rows[indexRow].Cells["IDCategory"].Value = st.IDCategory;
				dgvShowCategory.Rows[indexRow].Cells["CategoryName"].Value = st.CategoryName;
				dgvShowCategory.Rows[indexRow].Cells["Descriptions"].Value = st.Descriptions;
			}	
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FilmGenre db = new FilmGenre();
			db.IDCategory = txtIDCatogory.Text;
			db.CategoryName = txtCategoryName.Text;
			db.Descriptions = txtDescriptions.Text;
			Context.FilmGenres.Add(db);
			Context.SaveChanges();
			List<FilmGenre> filmGenres = Context.FilmGenres.ToList();
			LoadData(filmGenres);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			

			FilmGenre db = Context.FilmGenres.Where(m => m.IDCategory == txtIDCatogory.Text).SingleOrDefault();
			db.CategoryName = txtCategoryName.Text;
			db.Descriptions = txtDescriptions.Text;
			Context.SaveChanges();
			List<FilmGenre> filmGenres = Context.FilmGenres.ToList();
			LoadData(filmGenres);
		}

		private void dgvShowCategory_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtIDCatogory.Text = dgvShowCategory.CurrentRow.Cells["IDCategory"].Value.ToString();
			txtCategoryName.Text= dgvShowCategory.CurrentRow.Cells["CategoryName"].Value.ToString();
			if(dgvShowCategory.CurrentRow.Cells["Descriptions"].Value==null)
			{
				txtDescriptions.Text = "";
			}
			else
			{
				txtDescriptions.Text = dgvShowCategory.CurrentRow.Cells["Descriptions"].Value.ToString();
			}
			

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			FilmGenre db = Context.FilmGenres.Where(m => m.IDCategory == txtIDCatogory.Text).SingleOrDefault();
			Context.FilmGenres.Remove(db);
			Context.SaveChanges();
			List<FilmGenre> filmGenres = Context.FilmGenres.ToList();
			LoadData(filmGenres);
		}
	}
}
