using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGV.Models;

namespace CGV
{
    public partial class formShowTime : Form
    {
        CGVDBContext Context;
        public formShowTime()
        {

            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formShowTime_Load(object sender, EventArgs e)
        {
            try
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Movie> movies = Context.Movies.ToList();
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Room> rooms = Context.Rooms.ToList();
                FillRoomComboBox(rooms);
                FillDDComboBox(formatDetails);
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
                dgvShowTime.Rows[indexRow].Cells[0].Value = sv.IDShowtimes;
                dgvShowTime.Rows[indexRow].Cells[1].Value = sv.Room.IDRoom;
                dgvShowTime.Rows[indexRow].Cells[2].Value = sv.FormatDetail.Movie.MovieName;
                dgvShowTime.Rows[indexRow].Cells[3].Value = sv.FormatDetail.MovieFormat.MovieFormatName;
                dgvShowTime.Rows[indexRow].Cells[4].Value = sv.ShowTime1;
                dgvShowTime.Rows[indexRow].Cells[5].Value = sv.Fare;
            }
        }

        private void FillDDComboBox(List<FormatDetail> formatDetails)
        {
            this.comboBox2.DataSource = formatDetails;
            this.comboBox2.DisplayMember = "IDFormat";
            this.comboBox2.ValueMember = "IDFormat";
        }

        private void FillRoomComboBox(List<Room> rooms)
        {
            this.cmbRoom.DataSource = rooms;
            this.cmbRoom.DisplayMember = "IDRO";
            this.cmbRoom.ValueMember = "IDRoom";
        }

        private void dgvShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvShowTime.CurrentRow;
            textBox2.Text = index.Cells[5].Value.ToString();
            cmbRoom.Text = index.Cells[1].Value.ToString();
            label13.Text = index.Cells[2].Value.ToString();
            label14.Text = index.Cells[3].Value.ToString();
            dateTimePicker1.Text = index.Cells[4].Value.ToString();
            dateTimePicker2.Text = index.Cells[4].Value.ToString();
            textBox3.Text = index.Cells[0].Value.ToString();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 t = new Menu2();
            t.Show();
        }      
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Movie> movies = Context.Movies.ToList();
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Room> rooms = Context.Rooms.ToList();
                FillRoomComboBox(rooms);
                FillDDComboBox(formatDetails);
                BindGrid(showtimes);
            }
            else
            {
                string lichchieu = textBox1.Text;
                var tickets = Context.Showtimes.Where(p => p.FormatDetail.Movie.MovieName.Contains(lichchieu)
                ).ToList();
                BindGrid(tickets);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin hộ!");
                }
                else
                {
                    Showtime sv = new Showtime();
                    sv.IDShowtimes = textBox3.Text;
                    sv.IDRoom = cmbRoom.SelectedValue.ToString();
                    sv.IDFormat = comboBox2.Text;

                    DateTime time = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
                    sv.ShowTime1 = time;


                    sv.Fare = decimal.Parse(textBox2.Text);
                    Context.Showtimes.Add(sv);
                    Context.SaveChanges();

                    List<Showtime> showtimes = Context.Showtimes.ToList();
                    List<Movie> movies = Context.Movies.ToList();
                    List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                    List<Room> rooms = Context.Rooms.ToList();
                    FillRoomComboBox(rooms);
                    FillDDComboBox(formatDetails);
                    BindGrid(showtimes);
                    MessageBox.Show("Một lịch chiếu đã được chào đời!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Lịch chiếu được tạo phải lớn hơn hoặc bằng ngày hiện tại và ngày công chiếu của Rạp\nHoặc phòng chiếu " + cmbRoom.Text + " hiện đang chiếu 1 suất chiếu khác. Vui lòng chọn Phòng chiếu khác.", "CGV xin thông báo");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Showtime dbDelete = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == textBox3.Text);
            if (dbDelete != null)
            {
                Context.Showtimes.Remove(dbDelete);
                Context.SaveChanges();
                List<Showtime> showtimes = Context.Showtimes.ToList();
                List<Movie> movies = Context.Movies.ToList();
                List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                List<Room> rooms = Context.Rooms.ToList();
                FillRoomComboBox(rooms);
                FillDDComboBox(formatDetails);
                BindGrid(showtimes);
                MessageBox.Show("Lịch chiếu đó đã được chia ở thì Quá Khứ Đơn!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string v = textBox2.Text;
                Showtime dbUpdate = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == v);
                if (dbUpdate != null)
                {
                    dbUpdate.IDShowtimes = textBox3.Text;
                    dbUpdate.IDRoom = cmbRoom.Text;
                    dbUpdate.IDFormat = comboBox2.Text;
                    dbUpdate.ShowTime1 = dateTimePicker1.Value;
                    dbUpdate.Fare = decimal.Parse(textBox2.Text);
                    Context.SaveChanges();

                    List<Showtime> showtimes = Context.Showtimes.ToList();
                    List<Movie> movies = Context.Movies.ToList();
                    List<FormatDetail> formatDetails = Context.FormatDetails.ToList();
                    List<Room> rooms = Context.Rooms.ToList();
                    FillRoomComboBox(rooms);
                    FillDDComboBox(formatDetails);
                    BindGrid(showtimes);
                    MessageBox.Show("Đã sửa thành công rồi nhé!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Data u = new Data();
            u.Show();
        }

       
    }
}
