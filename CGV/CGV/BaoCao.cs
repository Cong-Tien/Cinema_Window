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
    public partial class BaoCao : Form
    {
        CGVDBContext Context;
        public BaoCao()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Ticket> tickets = Context.Tickets.ToList();
                List<Client> clients = Context.Clients.ToList();
                FillShowTimeComboBox(showtimes);
                //BindGrid(tickets);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillShowTimeComboBox(List<Showtime> showtimes)
        {
            this.cmbShowtime.DataSource = showtimes;
            this.cmbShowtime.DisplayMember = "IDShowtimes";
            this.cmbShowtime.ValueMember = "IDShowtimes"; ;
        }

        private void BindGrid(List<Ticket> tickets)
        {
            try
            {
                dgvTicket.Rows.Clear();
                foreach (var sv in tickets)
                {
                    int indexRow = dgvTicket.Rows.Add();
                    dgvTicket.Rows[indexRow].Cells[0].Value = sv.IDTicket;
                    dgvTicket.Rows[indexRow].Cells[1].Value = sv.LoaiVe;
                    dgvTicket.Rows[indexRow].Cells[2].Value = sv.Showtime.ShowTime1;
                    dgvTicket.Rows[indexRow].Cells[3].Value = sv.MaGheNgoi;
                    dgvTicket.Rows[indexRow].Cells[4].Value = sv.Client.NameClient;
                    dgvTicket.Rows[indexRow].Cells[5].Value = sv.TrangThai;
                    dgvTicket.Rows[indexRow].Cells[6].Value = sv.TienBanVe;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvTicket.CurrentRow;
            dateTimePicker1.Text = index.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lichchieu = cmbShowtime.Text;
            var tickets = Context.Tickets.Where(p => p.IDShowTimes.Contains(lichchieu)
            ).ToList();
            BindGrid(tickets);
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

            decimal tong = 0;
            decimal y = 0;
            //string a = txtMalc.Text;
            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                var ticket = row.Cells[6].Value;
                if (ticket != null)
                {

                    y = decimal.Parse(ticket.ToString());
                    tong += y;


                }
            }
            textBox3.Text = tong.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data h = new Data();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new formReport().Show();
        }
    }
}
