using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGV.Models;
using CGV.Helper;

namespace CGV
{
    public partial class TicketSales : Form
    {

        CGVDBContext Context;
        private string a1, b1, c1;

        public static string username = string.Empty;
        public TicketSales(string a, string b, string c)
        {
            InitializeComponent();
            this.a1 = a;
            this.b1 = b;
            this.c1 = c;
            Context = new CGVDBContext();
        }
        List<Button> listButton = new List<Button>();
        decimal displayPrice = 0;//Hiện thị giá vé
        decimal ticketPrice = 0;//Lưu giá vé gốc
        decimal total = 0;//Tổng giá tiền
        decimal discount = 0;//Tiền được giảm
        decimal payment = 0;//Tiền phải trả
        int plusPoint = 0;//Số điểm tích lũy khi mua vé
        private ClientFrennlly frm_DangNhapThanhCong;

        private void HideTableClient()
        {
            if (chkCustomer.Checked == true)
            {
                pnCustomer.Visible = true;
            }
            else
            {
                pnCustomer.Visible = false;
            }
        }
        private void TicketSales_Load(object sender, EventArgs e)
        {
            label2.Text = a1;
            label3.Text = b1;
            label4.Text = c1;
            InitializeSeat();
            List<Ticket> tickets = Context.Tickets.ToList();
            List<Showtime> showtimes = Context.Showtimes.ToList();
            List<Client> clients = Context.Clients.ToList();
            rdoAdult.Checked = true;
            chkCustomer.Enabled = false;
            grpLoaiVe.Enabled = false;
            HideTableClient();


        }

        public void InitializeSeat()
        {
            int seatCount = 56;
            for (int i = 0; i < seatCount; i++)
            {

                Button buttonSeat = new Button();


                buttonSeat.Width = 70;
                buttonSeat.Height = 70;
                if (i < 8)
                    buttonSeat.Text = "A" + (i + 1).ToString();
                if (i > 7 && i < 16)
                    buttonSeat.Text = "B" + (i + 1 - 8).ToString();
                if (i > 15 && i < 24)
                    buttonSeat.Text = "C" + (i + 1 - 16).ToString();
                if (i > 23 && i < 32)
                    buttonSeat.Text = "D" + (i + 1 - 24).ToString();
                if (i > 31 && i < 40)
                    buttonSeat.Text = "E" + (i + 1 - 32).ToString();
                if (i > 39 && i < 48)
                    buttonSeat.Text = "F" + (i + 1 - 40).ToString();
                if (i > 47 && i < 56)
                    buttonSeat.Text = "G" + (i + 1 - 48).ToString();
                buttonSeat.Click += new EventHandler(btnChooseASeat);
                buttonSeat.BackColor = Color.LightGray;
                flowSeat.Controls.Add(buttonSeat);

                List<Ticket> ves = Context.Tickets.Where(p => p.IDShowTimes == label2.Text && p.TrangThai == 1).ToList();
                foreach (Ticket v in ves)
                {
                    if (v != null)
                    {
                        if (v.MaGheNgoi == buttonSeat.Text)
                        {
                            if (v.TrangThai == 1)
                            {
                                buttonSeat.BackColor = Color.Yellow;
                                //v.TrangThai = 3;
                                //Context.SaveChanges();
                            }
                            else
                            {
                                buttonSeat.BackColor = Color.LightGray;

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(" không tìm thấy lịch chiếu");
                    }
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listButton.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            if (chkCustomer.Checked == true)
            {
                foreach (Button btn in listButton)
                {
                    Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);
                    {
                        if (t != null)
                        {
                            Client x = Context.Clients.FirstOrDefault(p => p.NameClient == lblCustomerName.Text);
                            if (x != null)
                            {
                                t.IDClient = x.IDClient;
                                x.PlushPoints += plusPoint;
                                btn.BackColor = Color.Yellow;

                                Context.SaveChanges();
                            }
                        }
                    }


                }

            }
            else
            {
                foreach (Button btn in listButton)
                {
                    btn.BackColor = Color.Yellow;
                }
            }

            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko?",
                "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listButton)
            {
                btn.BackColor = Color.LightGray;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void RestoreDefault()
        {

            listButton.Clear();

            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            chkCustomer.Checked = false;
            chkCustomer.Enabled = false;

            HideTableClient();
            textBox1.Clear();
            lblCustomerName.Text = "";
            lblPoint.Text = "";
            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
            plusPoint = 0;

            LoadBill();

            //List<Button> listButton = new List<Button>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseShowTimes v = new ChooseShowTimes();
            v.Show();
        }
      
        private void chkCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                //ClientFrennlly frm = new ClientFrennlly();
                // frm += DangNhapThanhCong;
                // if (frm.ShowDialog() == DialogResult.OK)
                //{

                   
                    
                //lblCustomerName.Text = "";
                HideTableClient();
                //}
                //else
                //{
                //    chkCustomer.Checked = true;
                //    HideTableClient();
                //}
            }
            else
            {
                HideTableClient();
                lblCustomerName.Text = null;
                textBox1.Clear();
            }
            HideTableClient();
        }


        

        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.LightGray)
                {
                    grpLoaiVe.Enabled = true;
                    rdoAdult.Checked = true;
                    btn.BackColor = Color.Lime;
                    Showtime pare = Context.Showtimes.FirstOrDefault(p => p.IDShowtimes == label2.Text);
                    if (pare != null)
                    {
                        ticketPrice = pare.Fare;
                        Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);
                        t.TienBanVe = ticketPrice;
                        displayPrice = (decimal)t.TienBanVe;                      
                        lblTicketPrice.Text = ticketPrice.ToString();
                        total += ticketPrice;
                        t.TrangThai = 1;
                        Context.SaveChanges();
                        payment = total - discount;                       
                    }                                  
                    listButton.Add(btn);
                    plusPoint++;
                    lblPlusPoint.Text = plusPoint.ToString();

                }
                else
                {
                    btn.BackColor = Color.LightGray;
                    Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);

                    total -= (decimal)t.TienBanVe;
                    payment = total - discount;
                    t.TienBanVe = 0;
                    displayPrice = (decimal)t.TienBanVe;
                    t.TrangThai = 0;
                    plusPoint--;
                    Context.SaveChanges();
                    lblPlusPoint.Text = plusPoint.ToString();
                    grpLoaiVe.Enabled = false;

                    listButton.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế [" + btn.Text + "] đã có người mua. Vui lòng chọn ghế khác!" +
                    "Mãi Yêu!");
            }
            LoadBill();
            if (listButton.Count > 0)
            {
                chkCustomer.Enabled = true;
            }
            else
            {
                chkCustomer.Enabled = false;
            }
        }

        private void rdoAdult_Click(object sender, EventArgs e)
        {
            if (rdoAdult.Checked == true)
            {
                if (listButton.Count == 0) return;
                foreach (Button btn in listButton)
                {
                    Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);
                    t.LoaiVe = 1;
                    decimal oldPrice = (decimal)t.TienBanVe;
                    t.TienBanVe = ticketPrice;
                    Context.SaveChanges();
                    displayPrice = (decimal)t.TienBanVe;
                    total = total + (decimal)t.TienBanVe - oldPrice;
                    payment = total - discount;
                }
                LoadBill();
            }
        }

        private void rdoChild_Click(object sender, EventArgs e)
        {
            if (rdoChild.Checked == true)
            {
                if (listButton.Count == 0) return;
                foreach (Button btn in listButton)
                {
                    Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);
                    t.LoaiVe = 3;
                    decimal oldPrice = (decimal)t.TienBanVe;
                    t.TienBanVe = (decimal)0.7f * ticketPrice;
                    Context.SaveChanges();
                    displayPrice = (decimal)t.TienBanVe;
                    total = total + (decimal)t.TienBanVe - oldPrice;
                    payment = total - discount;
                }
                LoadBill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = Context.Clients.FirstOrDefault(p => p.IDClient == textBox1.Text);

            lblCustomerName.Text = client.NameClient;
            lblPoint.Text = client.PlushPoints.ToString();
            client.PlushPoints += plusPoint-1;
            Context.SaveChanges();
        }

        //private void lblCustomerName_TextChanged(object sender, EventArgs e)
        //{
        //    Client c = Context.Clients.FirstOrDefault(p => p.IDClient == comboBox1.Text);
        //    if (c != null)
        //    {
        //        lblCustomerName.Text = c.NameClient;
        //    }

        //}

        private void rdoStudent_Click(object sender, EventArgs e)
        {         
            if (rdoStudent.Checked == true)
            {
                if (listButton.Count == 0) return;
                foreach (Button btn in listButton)
                {
                    Ticket t = Context.Tickets.FirstOrDefault(p => p.MaGheNgoi == btn.Text && p.IDShowTimes == label2.Text);
                    t.LoaiVe = 2;                  
                    decimal oldPrice = (decimal)t.TienBanVe;
                    t.TienBanVe = (decimal)0.8f * ticketPrice;
                    Context.SaveChanges();
                    displayPrice = (decimal)t.TienBanVe;
                    total = total + (decimal)t.TienBanVe - oldPrice;
                    payment = total - discount;
                }
                LoadBill();
            }
        }

        private void LoadBill()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            lblTicketPrice.Text = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }       

    }
}
