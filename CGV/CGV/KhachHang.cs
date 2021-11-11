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
    public partial class KhachHang : Form
    {
        CGVDBContext Context = new CGVDBContext();
        public KhachHang()
        {
            InitializeComponent();
        }
        private void Dl()
        {
            txtmakh.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtid.Text = "";
            txtdiem.Text = "";
        }
        private void BindGrid(List<Client> clients)
        {
            dataGridView1.Rows.Clear();
            foreach (var nv in clients)
            {
                int indexRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[indexRow].Cells["makh"].Value = nv.IDClient;
                dataGridView1.Rows[indexRow].Cells["hoten"].Value = nv.NameClient;
                dataGridView1.Rows[indexRow].Cells["ngaysinh"].Value = nv.BirthdayClient;
                dataGridView1.Rows[indexRow].Cells["diachi"].Value = nv.AddressClient;
                dataGridView1.Rows[indexRow].Cells["sdt"].Value = nv.NumberPhoneClient;
                dataGridView1.Rows[indexRow].Cells["theid"].Value = nv.IDCardClient;
                dataGridView1.Rows[indexRow].Cells["Diem"].Value = nv.PlushPoints;

            }
        }
        private void LoadData()
        {
            List<Client> clients = Context.Clients.ToList();
            BindGrid(clients);
        }
        private void Them()
        {
            try
            {
                if (txtmakh.Text == "" || txthoten.Text == "" || txtid.Text == "" )
                {
                    throw new Exception("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    Client st = new Client();
                    st.IDClient = txtmakh.Text;
                    st.NameClient = txthoten.Text;

                    DateTime time = new DateTime(dtngaysinh.Value.Year, dtngaysinh.Value.Month, dtngaysinh.Value.Day, dtngaysinh.Value.Hour, dtngaysinh.Value.Minute, dtngaysinh.Value.Second);
                    //sv.ShowTime1 = time;
                    st.BirthdayClient = time;

                    st.AddressClient = txtdiachi.Text;
                    st.NumberPhoneClient = txtsdt.Text;
                    st.IDCardClient = int.Parse(txtid.Text);
                    st.PlushPoints = int.Parse(txtdiem.Text);
                    Context.Clients.Add(st);
                    Context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm Thành Công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Xoa()
        {
            Client dbDelete = Context.Clients.FirstOrDefault(p => p.IDClient == txtmakh.Text);
            if (dbDelete != null)
            {
                Context.Clients.Remove(dbDelete);
                Context.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa Thành Công!");
                Dl();
            }
        }
        private void Sua()
        {
            try
            {
                Client dbUpdate = Context.Clients.FirstOrDefault(p => p.IDClient == txtmakh.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.IDClient = txtmakh.Text;
                    dbUpdate.NameClient = txthoten.Text;
                    dbUpdate.BirthdayClient = dtngaysinh.Value;
                    dbUpdate.AddressClient = txtdiachi.Text;
                    dbUpdate.NumberPhoneClient = txtsdt.Text;
                    dbUpdate.IDCardClient = int.Parse(txtid.Text);
                    dbUpdate.PlushPoints = int.Parse(txtdiem.Text);
                    Context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Sửa Thành Công!");
                    Dl();
                    ;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập Tên Khách Hàng")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Nhập Tên Khách Hàng";
                txttimkiem.ForeColor = Color.Gray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            var index = dataGridView1.CurrentRow;
            txtmakh.Text = index.Cells["makh"].Value.ToString();
            txthoten.Text = index.Cells["hoten"].Value.ToString();
            dtngaysinh.Value = DateTime.Parse(index.Cells["ngaysinh"].Value.ToString());
            txtdiachi.Text = index.Cells["diachi"].Value.ToString();
            txtsdt.Text = index.Cells["sdt"].Value.ToString();
            txtid.Text = index.Cells["theid"].Value.ToString();
            txtdiem.Text = index.Cells["Diem"].Value.ToString();

        }

        private void btotimkiem_Click_1(object sender, EventArgs e)
        {
            string hoten = txttimkiem.Text.ToLower();
            var Clients = Context.Clients.Where(p => p.NameClient.ToLower().Contains(hoten)).ToList();
            BindGrid(Clients);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Them();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Xoa();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Sua();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoadData();
            txttimkiem.Text = "";
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

            this.Hide();
            Data m = new Data();
            m.Show();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}


