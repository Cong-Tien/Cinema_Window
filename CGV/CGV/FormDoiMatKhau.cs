using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CGV.Models;

namespace CGV
{
    public partial class FormDoiMatKhau : Form
    {
        CGVDBContext Context = new CGVDBContext();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Letien\LOCAL;initial catalog=QLCGV;Integrated Security=True");
        public void DoiMK()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select count (*) from Account where  UserName ='" + txttk1.Text + "'and Pass = '" + txtmkcu1.Text + "' ", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            errorProvider1.Clear();
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                if (txtmkmoi1.Text == txtnhapmkmoi1.Text)
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("update Account set Pass = '" + txtmkmoi1.Text + "' where UserName ='" + txttk1.Text + "'", connection);
                    DataTable dataTable1 = new DataTable();
                    sqlData.Fill(dataTable1);
                    MessageBox.Show("Đổi Mật Khẩu Thành Công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmkcu1.Text = "";
                    txttk1.Text = "";
                    txtmkmoi1.Text = "";
                    txtnhapmkmoi1.Text = "";

                }
                else
                {

                    errorProvider1.SetError(txtnhapmkmoi1, "Mật  Khẩu Nhập Lại Chưa Đúng!");
                }

            }
            else
            {

                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Cũ Không Đúng ", "THÔNG BÁO");
                txtmkcu1.Text = "";
                txttk1.Text = "";
                txtmkmoi1.Text = "";
                txtnhapmkmoi1.Text = "";

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttk1.Text) | string.IsNullOrEmpty(txtmkcu1.Text) | string.IsNullOrEmpty(txtmkmoi1.Text) | string.IsNullOrEmpty(txtnhapmkmoi1.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo");
                txtmkcu1.Text = "";
                txttk1.Text = "";
                txtmkmoi1.Text = "";
                txtnhapmkmoi1.Text = "";
            }
            else
            {
                DoiMK();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            TaiKhoan formQuanLyTaiKhoan = new TaiKhoan();
            formQuanLyTaiKhoan.ShowDialog();
        }
    }
}

