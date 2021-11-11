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
    public partial class NhanVien : Form
    {
        CGVDBContext Context;
        public NhanVien()
        {
            InitializeComponent();
            Context = new CGVDBContext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data u = new Data();
            u.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                List<Staff> staffs = Context.Staffs.ToList();
               
                BindGrid(staffs);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Staff> staffs)
        {
            dgvNV.Rows.Clear();
            foreach (var sv in staffs)
            {
                int indexRow = dgvNV.Rows.Add();
                dgvNV.Rows[indexRow].Cells[0].Value = sv.IDStaff;
                dgvNV.Rows[indexRow].Cells[1].Value = sv.NameStaff;
                dgvNV.Rows[indexRow].Cells[2].Value = sv.BirthdayStaff;
                dgvNV.Rows[indexRow].Cells[3].Value = sv.AddressStaff;
                dgvNV.Rows[indexRow].Cells[4].Value = sv.NumberPhoneStaff;
                dgvNV.Rows[indexRow].Cells[5].Value = sv.IDCard;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Staff dbUpdate = Context.Staffs.FirstOrDefault(p => p.IDStaff == textBox1.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.IDStaff = textBox1.Text;
                    dbUpdate.NameStaff = textBox2.Text;
                    dbUpdate.BirthdayStaff = dateTimePicker1.Value;
                    dbUpdate.AddressStaff = textBox3.Text;
                    dbUpdate.NumberPhoneStaff = textBox4.Text;
                    dbUpdate.IDCard = int.Parse(textBox5.Text);
                    Context.SaveChanges();

                    List<Staff> staffs = Context.Staffs.ToList();

                    BindGrid(staffs);
                    MessageBox.Show("Đã sửa thành công rồi nhé!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin hộ!");
                }
                else
                {
                    Staff sv = new Staff();
                    sv.IDStaff = textBox1.Text;
                    sv.NameStaff = textBox2.Text;
                    DateTime time = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);

                    sv.BirthdayStaff = time;
                    sv.AddressStaff = textBox3.Text;
                    sv.NumberPhoneStaff = textBox4.Text;
                    sv.IDCard = int.Parse(textBox5.Text);
                    Context.Staffs.Add(sv);
                    Context.SaveChanges();

                    List<Staff> staffs = Context.Staffs.ToList();

                    BindGrid(staffs);
                    MessageBox.Show("Một nhân viên đã được chào đời!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff dbDelete = Context.Staffs.FirstOrDefault(p => p.IDStaff == textBox1.Text);
            if (dbDelete != null)
            {
                Context.Staffs.Remove(dbDelete);
                Context.SaveChanges();
                List<Staff> staffs = Context.Staffs.ToList();

                BindGrid(staffs);
                MessageBox.Show("Nhân viên đó đã được chia ở thì Quá Khứ Đơn!");
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvNV.CurrentRow;
            textBox1.Text = index.Cells[0].Value.ToString();
            textBox2.Text = index.Cells[1].Value.ToString();
            dateTimePicker1.Text = index.Cells[2].Value.ToString();
            textBox3.Text = index.Cells[3].Value.ToString();
            if(index.Cells[4].Value==null)
            {
                textBox4.Text = "NULL";
            }
            else
            {
                textBox4.Text = index.Cells[4].Value.ToString();
            }

            textBox5.Text = index.Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<Staff> staffs = Context.Staffs.ToList();

            BindGrid(staffs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string manv = textBox6.Text.ToLower();
          
            var students = Context.Staffs.Where(p => p.NameStaff.ToLower().Contains(manv)
            ).ToList();

            BindGrid(students);
            
        }
    }
}
