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
    public partial class LoaiPhong : Form
    {
        CGVDBContext Context;
        public LoaiPhong()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            try
            {
                List<MovieFormat> movieFormats = Context.MovieFormats.ToList();
                
                BindGrid(movieFormats);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<MovieFormat> movieFormats)
        {
            dgvRoom.Rows.Clear();
            foreach (var sv in movieFormats)
            {
                int indexRow = dgvRoom.Rows.Add();
                dgvRoom.Rows[indexRow].Cells[0].Value = sv.IDMovieFormat;
                dgvRoom.Rows[indexRow].Cells[1].Value = sv.MovieFormatName;
               
            }
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvRoom.CurrentRow;
            textBox1.Text = index.Cells[0].Value.ToString();
            textBox2.Text = index.Cells[1].Value.ToString();
        }

 
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Data a = new Data();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin hộ!");
                }
                else
                {
                    MovieFormat sv = new MovieFormat();
                    sv.IDMovieFormat = textBox1.Text;
                    sv.MovieFormatName = textBox2.Text;

                    Context.MovieFormats.Add(sv);
                    Context.SaveChanges();
                    List<MovieFormat> movieFormats = Context.MovieFormats.ToList();

                    BindGrid(movieFormats);
                    MessageBox.Show("Một loại phòng đã được chào đời!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MovieFormat dbDelete = Context.MovieFormats.FirstOrDefault(p => p.IDMovieFormat == textBox1.Text);
            if (dbDelete != null)
            {
                Context.MovieFormats.Remove(dbDelete);
                Context.SaveChanges();
                List<MovieFormat> movieFormats = Context.MovieFormats.ToList();

                BindGrid(movieFormats);
                //MessageBox.Show("Sinh viên đó đã được chia ở thì Quá Khứ Đơn!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                MovieFormat dbUpdate = Context.MovieFormats.FirstOrDefault(p => p.IDMovieFormat == textBox1.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.IDMovieFormat = textBox1.Text;
                    dbUpdate.MovieFormatName = textBox2.Text;

                    Context.SaveChanges();
                    List<MovieFormat> movieFormats = Context.MovieFormats.ToList();

                    BindGrid(movieFormats);
                    MessageBox.Show("Đã sửa thành công rồi nhé!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
