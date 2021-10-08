using AppQLTraSua.dataAcessLayer;
using QLTraSua.BusinessAccessLayer;
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
    public partial class frmdangnhap : Form
    {
        private readonly taikhoanBAL taikhoanBAL;
        public frmdangnhap()
        {
            InitializeComponent();
            taikhoanBAL = new taikhoanBAL();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            if(userName =="" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập... ");
                return;
            }

            string error;
            if(taikhoanBAL.checklogin(userName, password, out error))
            {
                MessageBox.Show("login thành công");
                frmmain frmmain = new frmmain();
                frmmain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại{0}" + error);
            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = tspass.Checked ? '\0' : '*';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmdangky frmdangky = new frmdangky();
            frmdangky.Show();
        }
    }
}
