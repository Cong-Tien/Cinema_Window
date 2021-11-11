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
    public partial class PhanQuyen : Form
    {
        public static string Username = string.Empty;
        CGVDBContext db;
        public PhanQuyen()
        {
            //this.a1 = a;
            InitializeComponent();
            db = new CGVDBContext();
        }

       

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            //label1.Text = a1;
            //Username = FormLogic;
            this.label1.Text = Username;
            List<Account> accounts = db.Accounts.ToList();

            Account x = db.Accounts.FirstOrDefault(p => p.UserName == label1.Text);
            if(x.AccounType == 1)
            {
                
                    //MessageBox.Show("Bạn không thể truy cập vào hệ thống do quyền hạn khôngo đủ", "CGV xin thông báo");
                   
                //button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            List<Account> accounts = db.Accounts.ToList();

            Account x = db.Accounts.FirstOrDefault(p => p.UserName == label1.Text);
            if (x.AccounType == 1)
            {
                this.Show();
                MessageBox.Show("Bạn không thể truy cập vào hệ thống do quyền hạn không đủ", "CGV xin thông báo");
                
                button1.Enabled = false;
                
            }
            else
            {
                Data m = new Data();
                m.Show();
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ChooseShowTimes cst = new ChooseShowTimes();
            cst.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogic p = new FormLogic();
            p.Show();
        }
    }
}
