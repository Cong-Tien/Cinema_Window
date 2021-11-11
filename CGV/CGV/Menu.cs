using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGV
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 g = new Menu2();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang k = new KhachHang();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan tk = new TaiKhoan();
            tk.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanQuyen tr = new PhanQuyen();
            tr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 d = new Menu2();
            d.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            KhachHang k = new KhachHang();
            k.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan tk = new TaiKhoan();
            tk.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanQuyen m = new PhanQuyen();
            m.Show();
        }
    }
}
