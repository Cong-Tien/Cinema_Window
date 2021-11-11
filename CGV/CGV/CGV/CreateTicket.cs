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
    public partial class CreateTicket : Form
    {
        CGVDBContext Context;
        public CreateTicket()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void CreateTicket_Load(object sender, EventArgs e)
        {
            try
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Room> rooms = Context.Rooms.ToList();
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Movie> movies = Context.Movies.ToList();               
                BindGrid(showtimes);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Showtime> showtimes)
        {
            dgvShowTime.Rows.Clear();
            foreach (var st in showtimes)
            {
                int indexRow = dgvShowTime.Rows.Add();
                dgvShowTime.Rows[indexRow].Cells["malichchieu"].Value = st.IDShowtimes;
                dgvShowTime.Rows[indexRow].Cells["tenpc"].Value = st.Room.RoomName;
                dgvShowTime.Rows[indexRow].Cells["tenphim"].Value = st.FormatDetail.Movie.MovieName;
                dgvShowTime.Rows[indexRow].Cells["thoigian"].Value = st.ShowTime1;
                dgvShowTime.Rows[indexRow].Cells["tinhtrang"].Value = st.Statues;
            }
        }

        private void dgvShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                var index = dgvShowTime.CurrentRow;
                txtMalc.Text = index.Cells["malichchieu"].Value.ToString();
                txtPhim.Text = index.Cells["tenphim"].Value.ToString();
                txtPhong.Text = index.Cells["tenpc"].Value.ToString();
                txtTime.Text = index.Cells["thoigian"].Value.ToString();                           
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            try
            { 
                if(txtMalc.Text=="")
                {
                    MessageBox.Show("Vui lòng chọn Lịch chiếu để tạo Vé");
                }
                else
                {
                    Showtime lc = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == txtMalc.Text);

                    if (lc != null)
                    {
                        if (lc.Statues == 0)
                        {
                            int seatCount = 56;
                            for (int i = 0; i < seatCount; i++)
                            {
                                Ticket v = new Ticket();
                                Button buttonSeat = new Button();

                                buttonSeat.Width = 70;
                                buttonSeat.Height = 70;
                                if (i < 8)
                                    buttonSeat.Text = "A" + (i + 1).ToString();
                                if (i > 7 && i < 16)
                                    buttonSeat.Text = "B" + (i + 1 - 8).ToString();
                                if (i > 15 && i < 24)
                                    buttonSeat.Text = "C" + (i + 1 - 16).ToString();
                                if (i > 23 && i < 32)
                                    buttonSeat.Text = "D" + (i + 1 - 24).ToString();
                                if (i > 31 && i < 40)
                                    buttonSeat.Text = "E" + (i + 1 - 32).ToString();
                                if (i > 39 && i < 48)
                                    buttonSeat.Text = "F" + (i + 1 - 40).ToString();
                                if (i > 47 && i < 56)
                                    buttonSeat.Text = "G" + (i + 1 - 48).ToString();
                                v.MaGheNgoi = buttonSeat.Text;
                                var x = txtMalc.Text;
                                v.IDShowTimes = x;
                                v.TienBanVe = 0;
                                Context.Tickets.Add(v);

                            }
                            MessageBox.Show("Đã tạo vé thành công");


                            Context.SaveChanges();
                            List<Ticket> tickets = Context.Tickets.ToList();
                            List<Showtime> showtimes = Context.Showtimes.ToList();                           
                            lc.Statues = 1;                          
                            Context.SaveChanges();
                            BindGrid(showtimes);
                        }
                        else
                        {
                            MessageBox.Show("Lịch chiếu này đã được tạo");
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGridTicket(List<Ticket> tickets)
        {
            dgvTicket.Rows.Clear();
            foreach (var t in tickets)
            {
                int indexRow = dgvTicket.Rows.Add();
                dgvTicket.Rows[indexRow].Cells["idve"].Value = t.IDTicket;
                dgvTicket.Rows[indexRow].Cells["loaive"].Value = t.LoaiVe;
                dgvTicket.Rows[indexRow].Cells["malc"].Value = t.Showtime.IDShowtimes;
                dgvTicket.Rows[indexRow].Cells["maghe"].Value = t.MaGheNgoi;
                dgvTicket.Rows[indexRow].Cells["gia"].Value = t.TienBanVe;
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {          
                string lichchieu = txtMalc.Text;
                var tickets = Context.Tickets.Where(p => p.IDShowTimes.Contains(lichchieu)
                ).ToList();
                BindGridTicket(tickets);         
        }

        private void btnChooseShowTimes_Click(object sender, EventArgs e)
        {
            ChooseShowTimes choose = new ChooseShowTimes();
            this.Hide();
            choose.Show();
        }
    }
}
