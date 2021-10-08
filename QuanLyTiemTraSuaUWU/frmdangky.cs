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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Taikhoan = txtTenDangNhap.Text.Trim();
            string Matkhau = txtTaoMk.Text.Trim();
            string nhaplaimatkhau = txtnhaplaimk.Text.Trim();

            if (Taikhoan == "" || Matkhau == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập... ");
                return;
            }

            if(Matkhau != nhaplaimatkhau)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu... ");
                return;
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
    }
}
