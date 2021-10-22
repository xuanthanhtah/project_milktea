using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemTraSuaUWU
{
    public partial class frmdangky : Form
    {
        public frmdangky()
        {
            InitializeComponent();
        }
        TraSua ts = new TraSua();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Taikhoan = txtTenDangNhap.Text;
            string Matkhau = txtTaoMk.Text;
            string nhaplaimatkhau = txtnhaplaimk.Text;
            string gioitinh = "";
            string machucvu = "NV";
            if (radioButton1.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            if (Taikhoan == "" || Matkhau == "" ||nhaplaimatkhau=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập... ");
                return;
            }

            else if(Matkhau != nhaplaimatkhau)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu... ");
                return;
            }
            else
            {
                ts.ThemDangKy(gioitinh, machucvu, Taikhoan, nhaplaimatkhau);
                MessageBox.Show("Đăng Ký Thành Công");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtnhaplaimk.Text = "";
            txtTaoMk.Text = "";
            txtTenDangNhap.Text = "";
            txtTenDangNhap.Focus();
        }

        private void txtTaoMk_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            txtTaoMk.PasswordChar = tsdangky.Checked ? '\0' : '*';
            txtnhaplaimk.PasswordChar = tsdangky.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tsdangky_CheckedChanged(object sender, EventArgs e)
        {
            if (tsdangky.Checked == true)
            {
                txtTaoMk.PasswordChar = char.Parse("\0");
                txtnhaplaimk.PasswordChar= char.Parse("\0");
            }
            else
            {
                txtTaoMk.PasswordChar = '*';
                txtnhaplaimk.PasswordChar = '*';
            }
            txtnhaplaimk.Text = "";
            txtTaoMk.Text = "";
            txtTenDangNhap.Text = "";
            txtTenDangNhap.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
