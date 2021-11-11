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
    public partial class TaiKhoan : Form
    {
        CGVDBContext context = new CGVDBContext();

        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            List<Staff> staffs = context.Staffs.ToList();
            List<Account> accounts = context.Accounts.ToList();
            BindGrid(accounts);


        }
        private void DL()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            cboloaitk.Text = "";
            txttk.Text = "";

        }
        private void Them()
        {
            try
            {
                if (txttk.Text == "" || txttennv.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin!");
                }
                else
                {

                    Account ac = new Account();
                    ac.Pass = "Ahihi";
                    ac.IDStaff = txtmanv.Text;

                    ac.UserName = txttk.Text;
                    ac.AccounType = int.Parse(cboloaitk.Text);

                    context.Accounts.Add(ac);
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Đã Thêm Thành Công! \nMật khẩu mặc định là Ahihi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Xoa()
        {
            Account dbDelete = context.Accounts.FirstOrDefault(p => p.UserName == txttk.Text);
            if (dbDelete != null)
            {
                context.Accounts.Remove(dbDelete);
                context.SaveChanges();
                LoadData();
                DL();

            }
        }
        private void Sua()
        {
            try
            {
                Account dbUpdate = context.Accounts.FirstOrDefault(p => p.UserName == txttk.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.UserName = txttk.Text;
                    dbUpdate.AccounType = int.Parse(cboloaitk.Text);

                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Sửa Thành Công!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Account> accounts)
        {

            dtgwqltk.Rows.Clear();
            foreach (var tk in accounts)
            {
                int indexRow = dtgwqltk.Rows.Add();
                dtgwqltk.Rows[indexRow].Cells["manv"].Value = tk.Staff.IDStaff;
                dtgwqltk.Rows[indexRow].Cells["TenNV"].Value = tk.Staff.NameStaff;
                dtgwqltk.Rows[indexRow].Cells["taikhoan1"].Value = tk.UserName;
                dtgwqltk.Rows[indexRow].Cells["Loaitk"].Value = tk.AccounType;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Nhập Tên Nhân Viên";
                txttimkiem.ForeColor = Color.Gray;
            }
        }

     
        private void dtgwqltk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dtgwqltk.ReadOnly = true;

            var index = dtgwqltk.CurrentRow;
            txtmanv.Text = index.Cells["manv"].Value.ToString();
            txttennv.Text = index.Cells["TenNV"].Value.ToString();
            txttk.Text = index.Cells["taikhoan1"].Value.ToString();
            cboloaitk.Text = index.Cells["Loaitk"].Value.ToString();

        }
        private void btoxoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }


        private void cboloaitk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btoback_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Data n = new Data();
            n.Show();
        }

        private void btotimkiem_Click_1(object sender, EventArgs e)
        {
            string hoten = txttimkiem.Text.ToLower();
            var accounts = context.Accounts.Where(p => p.Staff.NameStaff.ToLower().Contains(hoten)).ToList();
            BindGrid(accounts);
        }

        private void btothem_Click_1(object sender, EventArgs e)
        {
            Them();
        }

        private void btoxoa_Click_1(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btosua_Click_1(object sender, EventArgs e)
        {
            Sua();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoadData();
            DL();
            txttimkiem.Text = "";
        }

        private void btodoimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau();
            formDoiMatKhau.ShowDialog();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                DL();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

