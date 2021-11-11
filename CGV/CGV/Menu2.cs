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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateMovie h = new CreateMovie();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTicket t = new CreateTicket();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            formShowTime c = new formShowTime();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateFilmGenre b = new CreateFilmGenre();
            b.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiPhong lp = new LoaiPhong();
            lp.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
             RoomMate r = new RoomMate();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DinhDang p = new DinhDang();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu n = new Menu();
            n.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateMovie h = new CreateMovie();
            h.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateTicket t = new CreateTicket();
            t.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            DinhDang p = new DinhDang();
            p.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            RoomMate r = new RoomMate();
            r.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateFilmGenre b = new CreateFilmGenre();
            b.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoaiPhong lp = new LoaiPhong();
            lp.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formShowTime c = new formShowTime();
            c.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu x = new Menu();
            x.Show();
        }
    }
}
