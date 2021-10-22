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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        TraSua ts = new TraSua();
        public DataTable dt;
        public void setNull()
        {
            cbbBan.Text = "";
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtTotal.Text = "";
            txtTimKiem.Text = "";
        }

        //setButton
        public void setButton(bool e)
        {
            btnKhongLuu.Enabled = !e;
            btnLuu.Enabled = !e;
            btnSua.Enabled = e;
            btnThem.Enabled = e;
            btnXoa.Enabled = e;
            btnThoat.Enabled = e;
            btnTimKiem.Enabled = e;
        }

        //SetKhoa
        public void setKhoa(bool e)
        {
            cbbBan.Enabled = !e;
            txtMaHD.ReadOnly = e;
            txtMaKH.ReadOnly = e;
            txtMaNV.ReadOnly = e;
            txtTotal.ReadOnly = e;
            txtTimKiem.ReadOnly = e;
            DateXuatHD.Enabled = !e;
        }

        //kiểm tra nhập
        public bool ktNhap()
        {
            if (cbbBan.SelectedValue.ToString() == "" || txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Nhập Thiếu Thông Tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtMaHD.TextLength < 3)
            {
                MessageBox.Show("Nhập Lại Mã Hóa Đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                double tongtien = 0;
                bool Total = double.TryParse(txtTotal.Text, out tongtien);
                if (!Total)
                {
                    MessageBox.Show("Số Tiền Nhập Không Hợp Lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return true;
        }
        public bool ktTrung(string maHoaDon)
        {
            int n = lvHoaDon.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (lvHoaDon.SelectedItems[i].SubItems[0].Text.ToString() == maHoaDon)
                {
                    return false;
                }
            }
            return true;
        }
        public void hienthiHoaDon()
        {
            lvHoaDon.Items.Clear();
            dt = ts.LayDSHoaDon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        public void hienThiBanAn()
        {
            DataTable dt = ts.LayDsBan();
            cbbBan.DataSource = dt;
            cbbBan.DisplayMember = "MaBan";
            cbbBan.ValueMember = "MaBan";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngay = string.Format("{0:MM/dd/yyyy}", DateXuatHD.Value);
            double tongtien = Convert.ToDouble(txtTotal.Text);
            int maNV = Convert.ToInt32(txtMaNV.Text);
            ts.ThemHoaDon(txtMaHD.Text, txtMaKH.Text, maNV, cbbBan.ValueMember.ToString(), ngay, tongtien);
            MessageBox.Show("Thêm mới sinh viên thành công", "Thông báo");
            hienthiHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    ts.xoaHoaDon(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthiHoaDon();
                    setNull();
                }
            }
            else
                MessageBox.Show("Chọn dòng cần xóa");
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvHoaDon.SelectedIndices.Count > 0)
                {
                    txtMaHD.Text = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                    txtMaNV.Text = lvHoaDon.SelectedItems[0].SubItems[1].Text;
                    txtMaKH.Text = lvHoaDon.SelectedItems[0].SubItems[2].Text;
                    cbbBan.SelectedIndex = cbbBan.FindString(lvHoaDon.SelectedItems[0].SubItems[3].Text);
                    //chuyển sang kiểu datetime
                    DateXuatHD.Value = DateTime.Parse(lvHoaDon.SelectedItems[0].SubItems[4].Text);
                    txtTotal.Text = lvHoaDon.SelectedItems[0].SubItems[5].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                string ngay = string.Format("{0:MM/dd/yyyy}", DateXuatHD.Value);
                long tongtien = long.Parse(txtTotal.Text);
                int maNV = int.Parse(txtMaNV.Text);
                ts.suaHoaDon(txtMaHD.Text, txtMaKH.Text, maNV, cbbBan.DisplayMember.ToString(), ngay, tongtien);
                hienthiHoaDon();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    DataTable dt = ts.timHoaDon(txtTimKiem.Text);
                    lvHoaDon.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListViewItem lvi = lvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                        lvi.SubItems.Add(dt.Rows[i][1].ToString());
                        lvi.SubItems.Add(dt.Rows[i][2].ToString());
                        lvi.SubItems.Add(dt.Rows[i][3].ToString());
                        lvi.SubItems.Add(dt.Rows[i][4].ToString());
                        lvi.SubItems.Add(dt.Rows[i][5].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            hienthiHoaDon();
            setNull();
            hienThiBanAn();
        }
    }
}
