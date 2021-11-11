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
    public partial class RoomMate : Form
    {
        CGVDBContext Context;
        public RoomMate()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void DL()
        {
            txtCinemaID.Text = "";
            txtCinemaName.Text = "";
            txtCinemaSeats.Text = "";
            txtCinemaStatus.Text = "";
            txtNumberOfRows.Text = "";
            txtSeatsPerRow.Text = "";
        }

        private void BindGrid(List<Room> rooms)
        {

            dataGridView1.Rows.Clear();
            foreach (var nv in rooms)
            {
                int indexRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[indexRow].Cells["maphong"].Value = nv.IDRoom;
                dataGridView1.Rows[indexRow].Cells["tenphong"].Value = nv.RoomName;
                dataGridView1.Rows[indexRow].Cells["manhinh"].Value = nv.MovieFormat.MovieFormatName;
                dataGridView1.Rows[indexRow].Cells["sochongoi"].Value = nv.TotalSeats;
                dataGridView1.Rows[indexRow].Cells["tinhtrang"].Value = nv.Condition;
                dataGridView1.Rows[indexRow].Cells["sohangghe"].Value = nv.TotalRowsSeats;
                dataGridView1.Rows[indexRow].Cells["ghemoihang"].Value = nv.TotalSeatsPerRow;
                if (nv.Condition == 1)
                {
                    dataGridView1.Rows[indexRow].Cells["tinhtrang"].Value = "Còn Chỗ";

                }
                else if (nv.Condition == 0)
                {
                    dataGridView1.Rows[indexRow].Cells["tinhtrang"].Value = "Hết Chỗ";
                }


            }
        }
        private void loadData()
        {
            List<Room> rooms = Context.Rooms.ToList();
            List<MovieFormat> moiveFormats = Context.MovieFormats.ToList();
            FillComboBox(moiveFormats);
            BindGrid(rooms);
        }
        private void FillComboBox(List<MovieFormat> moiveFormats)
        {
            this.cbomanhinh.DataSource = moiveFormats;
            this.cbomanhinh.DisplayMember = "MovieFormatName";
            this.cbomanhinh.ValueMember = "IDMovieFormat";
        }
        private void Them()
        {
            try
            {
                if (txtCinemaID.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    Room st = new Room();
                    st.IDRoom = txtCinemaID.Text;
                    st.RoomName = txtCinemaName.Text;
                    st.IDMovieFormat = cbomanhinh.SelectedValue.ToString();
                    st.TotalSeats = int.Parse(txtCinemaSeats.Text);
                    st.Condition = int.Parse(txtCinemaStatus.Text);
                    st.TotalRowsSeats = int.Parse(txtNumberOfRows.Text);
                    st.TotalSeatsPerRow = int.Parse(txtSeatsPerRow.Text);
                    Context.Rooms.Add(st);
                    Context.SaveChanges();
                    loadData();
                    MessageBox.Show("Thêm Thành Công!");
                    DL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Xoa()
        {
            Room dbDelete = Context.Rooms.FirstOrDefault(p => p.IDRoom == txtCinemaID.Text);
            if (dbDelete != null)
            {
                Context.Rooms.Remove(dbDelete);
                Context.SaveChanges();
                loadData();
                MessageBox.Show("Xóa Thành Công!");
                DL();

            }
        }
        private void Sua()
        {
            try
            {
                Room update = Context.Rooms.FirstOrDefault(p => p.IDRoom == txtCinemaID.Text);
                if (update != null)
                {
                    update.IDRoom = txtCinemaID.Text;
                    update.RoomName = txtCinemaName.Text;
                    update.IDMovieFormat = cbomanhinh.SelectedValue.ToString();
                    update.TotalSeats = int.Parse(txtCinemaSeats.Text);
                    update.Condition = int.Parse(txtCinemaStatus.Text);
                    update.TotalRowsSeats = int.Parse(txtNumberOfRows.Text);
                    update.TotalSeatsPerRow = int.Parse(txtSeatsPerRow.Text);
                    Context.SaveChanges();
                    loadData();
                    MessageBox.Show("Sửa Thành Công!");
                    DL();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormQuanLyPhong_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.ReadOnly = true;
            var index = dataGridView1.CurrentRow;
            txtCinemaID.Text = index.Cells["maphong"].Value.ToString();
            txtCinemaName.Text = index.Cells["tenphong"].Value.ToString();
            cbomanhinh.Text = index.Cells["manhinh"].Value.ToString();
            txtCinemaSeats.Text = index.Cells["sochongoi"].Value.ToString();
            txtCinemaStatus.Text = index.Cells["tinhtrang"].Value.ToString();
            txtNumberOfRows.Text = index.Cells["sohangghe"].Value.ToString();
            txtSeatsPerRow.Text = index.Cells["ghemoihang"].Value.ToString();
            if (index.Cells["tinhtrang"].Value.ToString() == "Còn Chỗ")
            {
                txtCinemaStatus.Text = "1";

            }
            else if (index.Cells["tinhtrang"].Value.ToString() == "Hết Chỗ")
            {
                txtCinemaStatus.Text = "0";
            }

        }
  
        private void RoomMate_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btoback_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Data formMenu = new Data();
            formMenu.Show();
        }

        private void btnInsertCinema_Click_1(object sender, EventArgs e)
        {
            Them();
        }

        private void btnDeleteCinema_Click_1(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnUpdateCinema_Click_1(object sender, EventArgs e)
        {
            Sua();
        }
    }

}

