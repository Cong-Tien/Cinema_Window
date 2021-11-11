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
    public partial class DoanhThu : Form
    {
        CGVDBContext Context;
        public DoanhThu()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {

            try
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();               
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Movie> movies = Context.Movies.ToList();                           
                List<Ticket> tickets = Context.Tickets.ToList();                           
                FillMoviecomboBox(movies);
               
                //BindGrid(showtimes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Showtime> showtimes)
        {

            dgvShowTime.Rows.Clear();
            foreach (var sv in showtimes)
            {
                int indexRow = dgvShowTime.Rows.Add();
                dgvShowTime.Rows[indexRow].Cells[0].Value = sv.FormatDetail.Movie.MovieName;
                dgvShowTime.Rows[indexRow].Cells[1].Value = sv.ShowTime1;
                dgvShowTime.Rows[indexRow].Cells[2].Value = sv.ShowTime1;
                //dgvShowTime.Rows[indexRow].Cells[3].Value = sv.ShowTime1;
                //dgvShowTime.Rows[indexRow].Cells[4].Value = sv.Tickets.;
            }
        }

        private void FillMoviecomboBox(List<Movie> movies)
        {
            this.cmbMoive.DataSource = movies;
            this.cmbMoive.DisplayMember = "MovieName";
            this.cmbMoive.ValueMember = "IDMovie";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            
        }
    }
}
