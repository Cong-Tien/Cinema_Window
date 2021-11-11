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
    public partial class FormLogic : Form
    {
        private static string Username = string.Empty;
        CGVDBContext Context;
        public FormLogic()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account a = Context.Accounts.FirstOrDefault(p => p.UserName == txttk.Text);
            if(a!=null)
            {
                if(a.Pass==txtmk.Text)
                {
                    this.Hide();
                    PhanQuyen.Username = txttk.Text;
                    PhanQuyen pq = new PhanQuyen();
                    
                    pq.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại", "CGV xin thông báo");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại", "CGV xin thông báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogic_Load(object sender, EventArgs e)
        {
            List<Account> accounts = Context.Accounts.ToList();
            //txttk.Text = "monster";
            //txtmk.Text = "12345";
            txttk.Text = "(Username)";
            txtmk.Text = "(Password)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtmk.PasswordChar = '*';
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtmk.PasswordChar=='*')
            {
                button4.BringToFront();
                txtmk.PasswordChar = '\0';
            }    
        }

        private void txttk_Click(object sender, EventArgs e)
        {
            txttk.Clear();
        }

        private void txtmk_Click(object sender, EventArgs e)
        {
            txtmk.Clear();
        }
    }
}
