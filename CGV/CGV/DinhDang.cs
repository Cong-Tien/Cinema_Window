using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGV.Models;

namespace CGV
{
    public partial class DinhDang : Form
    {
        CGVDBContext Context;
        public DinhDang()
          
        {
            Context = new CGVDBContext();
            InitializeComponent();
        }

        private void DinhDang_Load(object sender, EventArgs e)
        {

            try
            {
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Movie> movies = Context.Movies.ToList();
                List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
                FillMovieComboBox(movies);
                FillMovieFormatComboBox(formatDetails);
                BindGrid(formatDetails);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<FormatDetail> formatDetails)
        {
            dgvFD.Rows.Clear();
            foreach (var sv in formatDetails)
            {
                int indexRow = dgvFD.Rows.Add();
                dgvFD.Rows[indexRow].Cells[0].Value = sv.IDFormat;
                dgvFD.Rows[indexRow].Cells[1].Value = sv.Movie.IDMovie;
                dgvFD.Rows[indexRow].Cells[2].Value = sv.Movie.MovieName;
                dgvFD.Rows[indexRow].Cells[3].Value = sv.MovieFormat.IDMovieFormat;
                dgvFD.Rows[indexRow].Cells[4].Value = sv.MovieFormat.MovieFormatName;
            }
        }

        private void FillMovieComboBox(List<Movie> movies)
        {
            this.cmbMovie.DataSource = movies;
            this.cmbMovie.DisplayMember = "IDMovie";
            this.cmbMovie.ValueMember = "IDMovie";
        }

        private void FillMovieFormatComboBox(List<FormatDetail> formatDetails)
        {
            this.cmbManHinh.DataSource = formatDetails;
            this.cmbManHinh.DisplayMember = "MovieFormatName";
            this.cmbManHinh.ValueMember = "IDMovieFormat";
        }

        private void dgvFD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtStudenID.ReadOnly = true;
            var index = dgvFD.CurrentRow;
            textBox1.Text = index.Cells[0].Value.ToString();
            cmbManHinh.Text = index.Cells[1].Value.ToString();
            textBox2.Text = index.Cells[2].Value.ToString();
            cmbManHinh.Text = index.Cells[3].Value.ToString();
            textBox3.Text = index.Cells[4].Value.ToString();
        }

 
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Data p = new Data();
            p.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("Mời chọn mã phim!");
                }
                else
                {
                    FormatDetail sv = new FormatDetail();
                    sv.IDFormat = textBox1.Text;
                    sv.IDMovie = cmbMovie.Text;
                    sv.IDMovieFormat = cmbManHinh.Text;

                    Context.FormatDetails.Add(sv);
                    Context.SaveChanges();

                    List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                    List<Movie> movies = Context.Movies.ToList();
                    List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
                    FillMovieComboBox(movies);
                    FillMovieFormatComboBox(formatDetails);
                    BindGrid(formatDetails);
                    // MessageBox.Show("Một sinh viên đã được chào đời!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormatDetail dbDelete = Context.FormatDetails.FirstOrDefault(p => p.IDFormat == textBox1.Text);
            if (dbDelete != null)
            {
                Context.FormatDetails.Remove(dbDelete);
                Context.SaveChanges();

                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Movie> movies = Context.Movies.ToList();
                List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
                FillMovieComboBox(movies);
                FillMovieFormatComboBox(formatDetails);
                BindGrid(formatDetails);
                //MessageBox.Show("Sinh viên đó đã được chia ở thì Quá Khứ Đơn!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormatDetail dbUpdate = Context.FormatDetails.FirstOrDefault(p => p.IDFormat == textBox1.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.IDFormat = textBox1.Text;
                    dbUpdate.IDMovie = cmbMovie.Text;
                    dbUpdate.IDMovieFormat = cmbManHinh.Text;

                    Context.SaveChanges();
                    List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                    List<Movie> movies = Context.Movies.ToList();
                    List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
                    FillMovieComboBox(movies);
                    FillMovieFormatComboBox(formatDetails);
                    BindGrid(formatDetails);
                    //MessageBox.Show("Đã sửa thành công rồi nhé!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
            List<Movie> movies = Context.Movies.ToList();
            List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
            FillMovieComboBox(movies);
            FillMovieFormatComboBox(formatDetails);
            BindGrid(formatDetails);
        }
    }
}
