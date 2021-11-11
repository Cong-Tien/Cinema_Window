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
                List<Client> clients = Context.Clients.ToList();               
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
                            string q = txtMalc.Text;
                            Showtime ew = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == q);                           
                            //int seatCount = ;
                            for (int i = 0; i < ew.Room.TotalSeats; i++)
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
                                if (i > 55 && i < 64)
                                    buttonSeat.Text = "H" + (i + 1 - 48).ToString();
                                if (i > 63 && i < 72)
                                    buttonSeat.Text = "I" + (i + 1 - 48).ToString();
                                if (i > 71 && i < 80)
                                    buttonSeat.Text = "H" + (i + 1 - 48).ToString();
                                v.MaGheNgoi = buttonSeat.Text;
                                var x = txtMalc.Text;
                                v.IDShowTimes = x;
                                v.TienBanVe = 0;
                                v.LoaiVe = 0;
                                v.IDClient = "null";
                                v.TrangThai = 0;
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
                dgvTicket.Rows[indexRow].Cells["trangthai"].Value = t.TrangThai;
                dgvTicket.Rows[indexRow].Cells[6].Value = t.Client.NameClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data n = new Data();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showtime d = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == txtMalc.Text);
            {
                string a = d.IDShowtimes;
                List<Ticket> t = Context.Tickets.Where(p => p.IDShowTimes == txtMalc.Text).ToList();
                foreach(var g in t)
                {
                    if(g.TrangThai==1)
                    {
                        Context.Tickets.Remove(g);
                        Context.SaveChanges();
                    }    
                }    

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Showtime d = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == txtMalc.Text);
            {
                string a = d.IDShowtimes;
                List<Ticket> t = Context.Tickets.Where(p => p.IDShowTimes == txtMalc.Text).ToList();
                foreach (var g in t)
                {                 
                        Context.Tickets.Remove(g);
                         d.Statues = 0;
                        Context.SaveChanges();
                   
                }
                MessageBox.Show("Những vé của lịch chiếu " + txtMalc.Text + " đã được xóa");
                dgvTicket.Rows.Clear();
            }
        }

        private void dgvTicket_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int tong2 = 0;
            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                var ticket = row.Cells[0].Value;
                if (ticket != null)
                {
                    tong2 += 1;
                }
                textBox1.Text = tong2.ToString();

            }
            
            int tongvedaban = 0;
            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                var khoa = row.Cells[5].Value;
                if (khoa != null)
                {
                    if (khoa.ToString().Equals("1"))
                    {
                        tongvedaban += 1;
                    }
                    
                }
            }
            textBox2.Text = tongvedaban.ToString();

            //decimal tong = 0;
            //decimal y = 0;
            //string a = txtMalc.Text;
            //foreach (DataGridViewRow row in dgvTicket.Rows)
            //{
            //    var ticket = row.Cells[4].Value;
            //    if (ticket != null)
            //    {
                    
            //            y = decimal.Parse(ticket.ToString());
            //            tong += y;

                    
            //    }             
            //}
            //textBox3.Text = tong.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
