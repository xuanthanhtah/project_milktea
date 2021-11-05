using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQLTraSua.dataAcessLayer.models;

namespace QuanLyTiemTraSuaUWU
{
    
    public partial class frmkhachhang : Form
    {
        dbqltrasuauwu context = new dbqltrasuauwu();
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> kHACHHANGs = context.KHACHHANGs.ToList();
            dodulieudgv(kHACHHANGs);
        }

        private void dodulieudgv(List<KHACHHANG> kHACHHANGs)
        {
            dgvkhachhang.Rows.Clear();
            foreach (var item in kHACHHANGs)
            {
                int index = dgvkhachhang.Rows.Add();
                dgvkhachhang.Rows[index].Cells[0].Value = item.MaKhachHang;
                dgvkhachhang.Rows[index].Cells[1].Value = item.Hoten;
                dgvkhachhang.Rows[index].Cells[2].Value = item.GioiTinh;
                dgvkhachhang.Rows[index].Cells[3].Value = item.SDT;
            }
        }

        private void btxthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvkhachhang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvkhachhang.CurrentRow.Selected = true;
                    txtmakhachhang.Text = dgvkhachhang.Rows[e.RowIndex].Cells["dgvmakhachhang"].FormattedValue.ToString();
                    txttenkhachhang.Text = dgvkhachhang.Rows[e.RowIndex].Cells["dgvtenkhachhang"].FormattedValue.ToString();
                    txtsodienthoai.Text = dgvkhachhang.Rows[e.RowIndex].Cells["dgvsodienthoai"].FormattedValue.ToString();
                    cbbgioitinh.Text = dgvkhachhang.Rows[e.RowIndex].Cells["dgvgioitinh"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnthemsua_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                if (checkidKh(txtmakhachhang.Text) == -1)
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.MaKhachHang = txtmakhachhang.Text;
                    kh.Hoten = txttenkhachhang.Text;
                    kh.GioiTinh = cbbgioitinh.Text;
                    kh.SDT = txtsodienthoai.Text;

                    context.KHACHHANGs.AddOrUpdate(kh);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"thêm khách hàng {kh.Hoten} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.MaKhachHang = txtmakhachhang.Text;
                    kh.Hoten = txttenkhachhang.Text;
                    kh.GioiTinh = cbbgioitinh.Text;
                    kh.SDT = txtsodienthoai.Text;

                    context.KHACHHANGs.AddOrUpdate(kh);
                    context.SaveChanges();

                    loadDGV();
                    loadform();
                    MessageBox.Show($"chỉnh sữa dữ liệu khách hàng {kh.Hoten} thành công", "Thông Báo", MessageBoxButtons.OK);

                }
            }
        }

        private void loadform()
        {
            txtmakhachhang.Clear();
            txttenkhachhang.Clear();
            txtsodienthoai.Clear();
            txtmakhachhang.Focus();
        }

        private void loadDGV()
        {
            List<KHACHHANG> listkhachhang = context.KHACHHANGs.ToList();
            dodulieudgv(listkhachhang);
        }

        private int checkidKh(string idnewkhachhang)
        {
            int length = dgvkhachhang.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvkhachhang.Rows[i].Cells[0].Value != null)
                    if (dgvkhachhang.Rows[i].Cells[0].Value.ToString() == idnewkhachhang)
                        return i;
            }
            return -1;
        }
        private bool checkdatainput()
        {
            if (txtmakhachhang.Text == "" || txttenkhachhang.Text == "" || txtsodienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return false;
            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtsodienthoai.Text, out kq);
                if (!ketqua)
                {
                    MessageBox.Show("Số điện thoại chưa đúng!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string idKh = txtmakhachhang.Text;
            KHACHHANG deletekhachhang = context.KHACHHANGs.FirstOrDefault(p => p.MaKhachHang == idKh);
            if (deletekhachhang != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa khách hàng {deletekhachhang.Hoten} không ?", "Thông báo cho bạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    context.KHACHHANGs.Remove(deletekhachhang);
                    context.SaveChanges();

                    loadform();
                    loadDGV();

                    MessageBox.Show($"Xóa khách hàng {deletekhachhang.Hoten} thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            reportkhachhang reportkhachhang = new reportkhachhang();
            reportkhachhang.Show();
        }
    }
}
