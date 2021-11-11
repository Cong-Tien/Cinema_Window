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
using CGV.Helper;

namespace CGV
{
    public partial class ClientFrennlly : Form
    {
        //public event hienThiTenKhachHang DangNhapThanhCong;
        CGVDBContext Context;
        public ClientFrennlly()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }
        private void KhachHangThanhVien_Load(object sender, EventArgs e)
        {
            textBox1.Text = "C02";
            textBox2.Text = "Nguyễn Mai Hương (khách hàng thân thiết )";
            List<Client> clients = Context.Clients.ToList();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string v = textBox1.Text;
            string k = textBox2.Text;
            Client x = Context.Clients.FirstOrDefault(p => p.IDClient == v);
            if (x != null)
            {
                if (x.NameClient == k)
                {
                    //TicketSales.username = textBox2.Text;
                    this.Close();
                    //DangNhapThanhCong(textBox2.Text);
                    
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
