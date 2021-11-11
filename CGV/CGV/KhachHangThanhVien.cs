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
    public partial class KhachHangThanhVien : Form
    {
        CGVDBContext Context;
        public KhachHangThanhVien()
        {          
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void KhachHangThanhVien_Load(object sender, EventArgs e)
        {
            textBox1.Text = "C01";
            textBox2.Text = "Phùng Xuân Đoan (khách hàng đen)";
            List<Client> clients = Context.Clients.ToList();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string v = textBox1.Text;
            string k = textBox2.Text;
            Client x = Context.Clients.FirstOrDefault(p => p.IDClient == v);
            if(x!=null)
            {
                if(x.NameClient == k)
                {
                    this.Hide();
                    TicketSales.username = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("Thông tin khách hàng không đúng \nVui lòng kiểm tra lại thông tin", "CGV xin thông báo");
                }
            }
            else
            {
                MessageBox.Show("Thông tin khách hàng không đúng \nVui lòng kiểm tra lại thông tin", "CGV xin thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
