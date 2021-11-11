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
    public partial class ChooseShowTimes : Form
    {
        CGVDBContext Context;
        public ChooseShowTimes()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void ChooseShowTimes_Load(object sender, EventArgs e)
        {
            try
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Room> rooms = Context.Rooms.ToList();
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Movie> movies = Context.Movies.ToList();
                FillShowTimecomboBox(showtimes);
                FillRoomcomboBox(rooms);
                FillMoviecomboBox(movies);
                cmbMovie.Text = "";
                cmbRoom.Text = "";
                cmbShowTime.Text = "";
                //BindGrid(showtimes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillMoviecomboBox(List<Movie> movies)
        {
            this.cmbMovie.DataSource = movies;
            this.cmbMovie.DisplayMember = "MovieName";
            this.cmbMovie.ValueMember = "IDMovie";
        }

        private void FillRoomcomboBox(List<Room> rooms)
        {
            this.cmbRoom.DataSource = rooms;
            this.cmbRoom.DisplayMember = "RoomName";
            this.cmbRoom.ValueMember = "IDRoom";
        }

        private void BindGrid(List<Showtime> showtimes)
        {
            dgvShowTime.Rows.Clear();
            foreach (var sv in showtimes)
            {
                int indexRow = dgvShowTime.Rows.Add();
                dgvShowTime.Rows[indexRow].Cells["idlc"].Value = sv.IDShowtimes;
                dgvShowTime.Rows[indexRow].Cells["idpc"].Value = sv.Room.RoomName;
                dgvShowTime.Rows[indexRow].Cells["phim"].Value = sv.FormatDetail.Movie.MovieName;
                dgvShowTime.Rows[indexRow].Cells["thoigian"].Value = sv.ShowTime1;
                dgvShowTime.Rows[indexRow].Cells["tinhtrang"].Value = sv.Statues;
            }
        }

        

        private void FillShowTimecomboBox(List<Showtime> showtimes)
        {
            this.cmbShowTime.DataSource = showtimes;
            this.cmbShowTime.DisplayMember = "IDShowtimes";
            this.cmbShowTime.ValueMember = "IDShowtimes";
        }

       

        private void dgvShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvShowTime.CurrentRow;
            cmbShowTime.Text = index.Cells["idlc"].Value.ToString();
            cmbMovie.Text = index.Cells["phim"].Value.ToString();
            cmbRoom.Text = index.Cells["idpc"].Value.ToString();
            dtpShowTime.Text = index.Cells["thoigian"].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string lichchieu = cmbShowTime.Text;
            String phong = cmbRoom.Text;
            var tickets = Context.Showtimes.Where(p => p.IDShowtimes.Equals(lichchieu) || p.Room.RoomName.Equals(phong)
            ).ToList();
            BindGrid(tickets);
        }
     
        private void dgvShowTime_DoubleClick(object sender, EventArgs e)
        {
            //string text = cmbShowTime.Text;
            TicketSales p = new TicketSales(cmbShowTime.Text, cmbMovie.Text, dtpShowTime.Text);
            this.Hide();
            p.Show();
        }
    }
}
