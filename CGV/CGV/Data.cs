using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;

namespace CGV
{
    public partial class Data : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Data()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem2, true);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            TaiKhoan u = new TaiKhoan();
            u.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            KhachHang p = new KhachHang();
            p.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            PhanQuyen v = new PhanQuyen();
            v.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            CreateMovie a = new CreateMovie();
            a.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            CreateFilmGenre c = new CreateFilmGenre();
            c.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            LoaiPhong y = new LoaiPhong();
            y.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            formShowTime b = new formShowTime();
            b.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            CreateTicket t = new CreateTicket();
            t.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            DinhDang i = new DinhDang();
            i.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            RoomMate r = new RoomMate();
            r.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            NhanVien l = new NhanVien();
            l.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            BaoCao o = new BaoCao();
            o.Show();
        }
    }
}