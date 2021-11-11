using CGV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV
{
	public partial class CreateMovie : Form
	{
		CGVDBContext Context;

		public CreateMovie()
		{
			InitializeComponent();
			Context = new CGVDBContext();
		}

		private string GetIdMovie()
		{
			var lastMovie = Context.Movies.OrderByDescending(x => x.IDMovie).FirstOrDefault();
			int idMovie;
			if (lastMovie == null) idMovie = 0;
			else idMovie = Convert.ToInt32(lastMovie.IDMovie.Substring(1));

			if (idMovie < 9) return "M0" + (idMovie + 1).ToString();
			return "M" + (idMovie + 1).ToString();
		}
		private void LoadGridViewMovies()
		{

			gridViewMovies.Rows.Clear();
			var listMovie = Context.Movies.ToList();
			foreach (var item in listMovie)
			{
				gridViewMovies.Rows.Add(item.IDMovie, item.MovieName, item.DescriptionFilm,
					item.TotalTime, item.PremiereDate, item.Productor, item.Director,
					item.ProductionYear, item.Posters);
			}
		}
		private void LoadCategories()
		{
			var listCategories = Context.FilmGenres.ToList();
			if (listCategories.Count > 0)
			{
				listboxCategory.DisplayMember = "CategoryName";
				listboxCategory.ValueMember = "IDCategory";
				listboxCategory.DataSource = listCategories;
				listboxCategory.SelectedIndex = -1;
			}
		}
		private void CreateMovie_Load(object sender, EventArgs e)
		{
			LoadGridViewMovies();
			LoadCategories();
			txtMovieId.Text = GetIdMovie();
			btnEdit.Enabled = false;
			btnDel.Enabled = false;
		}
		private void btnChooseImage_Click(object sender, EventArgs e)
		{
			var fileName = "";
			OpenFileDialog open = new OpenFileDialog();
			if (open.ShowDialog() == DialogResult.OK)
			{
				fileName = open.FileName;
			}
			if (fileName != "")
			{
				picturePoster.Image = new Bitmap(fileName);
			}
		}

		public byte[] ConvertImageToByteArray(Image img)
		{
			using (var ms = new MemoryStream())
			{
				img.Save(ms, img.RawFormat);
				return ms.ToArray();
			}
		}
		public Image ConvertByteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
			ms.Write(byteArrayIn, 0, byteArrayIn.Length);
			return Image.FromStream(ms, true);
		}

		private void ResetForm()
		{
			txtMovieId.Text = GetIdMovie();
			txtMovieName.Text = "";
			txtDescription.Text = "";
			txtTotalTime.Text = "";
			dtpPremiereDate.Value = DateTime.Now;
			txtProductor.Text = "";
			txtDirector.Text = "";
			txtProductionYear.Text = "";
			picturePoster.Image = null;
			btnAdd.Enabled = true;
			btnEdit.Enabled = false;
			btnDel.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var movie = new Movie();
			if (txtMovieName.Text != "" && txtDescription.Text != ""
				&& txtDirector.Text != "" && txtProductionYear.Text != ""
				&& txtProductor.Text != "" && txtTotalTime.Text != "" && picturePoster.Image != null)
			{
				try
				{
					movie.IDMovie = txtMovieId.Text;
					movie.MovieName = txtMovieName.Text;
					movie.DescriptionFilm = txtDescription.Text;
					movie.TotalTime = Convert.ToDouble(txtTotalTime.Text);
					movie.PremiereDate = dtpPremiereDate.Value;
					movie.Productor = txtProductor.Text;
					movie.Director = txtDirector.Text;
					movie.ProductionYear = Convert.ToInt32(txtProductionYear.Text);
					movie.Posters = ConvertImageToByteArray(picturePoster.Image);

					Context.Movies.Add(movie);
					Context.SaveChanges();

					if (listboxCategory.SelectedItems.Count > 0)
					{
						var movieDetails = new List<MovieDetails>();
						for (var i = 0; i < listboxCategory.SelectedItems.Count; i++)
						{
							var item = listboxCategory.SelectedItems[i].GetType().GetProperty(listboxCategory.ValueMember).GetValue(listboxCategory.SelectedItems[i]);
							var movieDetail = new MovieDetails();
							movieDetail.IDMovie = movie.IDMovie;
							movieDetail.IDCategory = item.ToString();
							movieDetails.Add(movieDetail);
						}
						Context.MovieDetails.AddRange(movieDetails);
						Context.SaveChanges();
					}

					MessageBox.Show("Thêm thành công");

					ResetForm();
					LoadGridViewMovies();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					MessageBox.Show("Có lỗi trong quá trình xử lý!");
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa nhập dữ liệu");
			}
		}

		private void gridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnAdd.Enabled = false;
			btnEdit.Enabled = true;
			btnDel.Enabled = true;
			if (e.RowIndex < 0) return;

			txtMovieId.Text = gridViewMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtMovieName.Text = gridViewMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtDescription.Text = gridViewMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtTotalTime.Text = gridViewMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
			dtpPremiereDate.Text = gridViewMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtProductor.Text = gridViewMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtDirector.Text = gridViewMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtProductionYear.Text = gridViewMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
			if (gridViewMovies.Rows[e.RowIndex].Cells[8].Value != null)
			{
				picturePoster.Image = ConvertByteArrayToImage((byte[])gridViewMovies.Rows[e.RowIndex].Cells[8].Value);
			}
			else
			{
				picturePoster.Image = null;
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var movie = Context.Movies.Find(txtMovieId.Text);
			if (movie != null)
			{
				try
				{
					movie.IDMovie = txtMovieId.Text;
					movie.MovieName = txtMovieName.Text;
					movie.DescriptionFilm = txtDescription.Text;
					movie.TotalTime = Convert.ToDouble(txtTotalTime.Text);
					movie.PremiereDate = dtpPremiereDate.Value;
					movie.Productor = txtProductor.Text;
					movie.Director = txtDirector.Text;
					movie.ProductionYear = Convert.ToInt32(txtProductionYear.Text);
					movie.Posters = ConvertImageToByteArray(picturePoster.Image);

					Context.SaveChanges();
					MessageBox.Show("Sửa thành công");
					ResetForm();
					LoadGridViewMovies();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					MessageBox.Show("Có lỗi trong quá trình xử lý");
				}
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Xác nhận xóa phim này!",
										"Cảnh báo",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				var movie = Context.Movies.SingleOrDefault(x => x.IDMovie == txtMovieId.Text);
				if (movie != null)
				{
					Context.Movies.Remove(movie);
					Context.SaveChanges();
					MessageBox.Show("Xóa thành công");
					ResetForm();
					LoadGridViewMovies();
				}
			}
		}

        private void picturePoster_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
			Data l = new Data();
			l.Show();
        }
    }
}
