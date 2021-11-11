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
//using System.Globalization;


namespace CGV
{
    public partial class formReport : Form
    {
        CGVDBContext Context;
        public formReport()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            comboBox1.Text="";
            List<Showtime> showtimes = Context.Showtimes.ToList();
            fillShowTime(showtimes);
        }

        private void fillShowTime(List<Showtime> showtimes)
        {
            this.comboBox1.DataSource = showtimes;
            this.comboBox1.DisplayMember = "IDShowTimes";
            this.comboBox1.ValueMember = "IDShowTimes";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCGVDataSet1.SelectShowTime' table. You can move, or remove it, as needed.
            this.SelectShowTimeTableAdapter.Fill(this.QLCGVDataSet1.SelectShowTime, comboBox1.SelectedValue.ToString());
            // TODO: This line of code loads data into the 'QLCGVDataSet.Ticket' table. You can move, or remove it, as needed.
            this.TicketTableAdapter.Fill(this.QLCGVDataSet.Ticket);

            this.reportViewer1.RefreshReport();
        }
    }
}
