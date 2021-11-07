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
        public bool themmoi = true;
        TraSua ts = new TraSua();
        public DataTable dt;
        void setButtons(bool e)
        {
            btnXoa.Enabled = e;
            btnSua.Enabled = e;
            btnTimKiem.Enabled = e;
            btnThoat.Enabled = e;
        }

        //set khoa hóa đơn
        void setKhoaHD(bool e)
        {
            txtMaHD.ReadOnly = e;
            txtMaKH.ReadOnly = e;
            cbbManv.Enabled = !e;
            cbbMaBan.Enabled = !e;
            txtTenNV.ReadOnly = !e;
            dateBan.Enabled = !e;
        }

        //set khoa CTHD
        void setKhoaCTHD(bool e)
        {
            cbbMaMon.Enabled = !e;
            txtTenMon.ReadOnly = e;
            txtGia.ReadOnly = e;
            txtSL.ReadOnly = e;
           
        }
        private void setNullHD()
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtTenNV.Clear();
            txtTongHD.Clear();
        }
        //setNull CTHD
        void setNullCTHD()
        {
            txtTenMon.Text = "";
            txtGia.Text = "0";
            txtSL.Text = "0";
            //txtTongHD.Clear();
        }
        //Load mã nhân viên lên combobox
        void hienthiMaNV()
        {
            DataTable dt = ts.LayDsMaNV();
            cbbManv.DataSource = dt;
            cbbManv.DisplayMember = "MaNV";
            cbbManv.ValueMember = "MaNV";
        }

        //Load mã bàn lên combobox
        void hienthiMaBan()
        {
            DataTable dt = ts.LayDsMaBan();
            cbbMaBan.DataSource = dt;
            cbbMaBan.DisplayMember = "MaBan";
            cbbMaBan.ValueMember = "MaBan";
        }

        //Load mã món ăn lên cbbMaMon
        void hienthiMaMon()
        {
            DataTable dt = ts.LayDsMaMon();
            cbbMaMon.DataSource = dt;
            cbbMaMon.DisplayMember = "MaMonAn";
            cbbMaMon.ValueMember = "MaMonAn";
        }
        //load thông tin hóa đơn
        void hienthiHD()
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

        //Load thông tin chi tiết hóa đơn
        void hienthiCTHD()
        {
            lvCTHD.Items.Clear();
            dt = ts.LayDSCTHD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvCTHD.Items.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }

        bool ktMaHD(string maHD)
        {
            for (int i = 0; i < lvHoaDon.Items.Count; i++)
            {
                if (lvHoaDon.Items[i].SubItems[0].Text == maHD)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại");
                    return false;
                }
            }
            return true;
        }

        bool ktNhapHD()
        {
            if (txtMaHD.Text == "" || txtMaKH.Text == "" || cbbManv.SelectedValue.ToString() == "" || cbbMaBan.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtMaHD.TextLength < 3)
            {
                MessageBox.Show("Mã hóa đơn không hợp lê", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        double tinhtongTien()
        {
            double s = 0;
            double gia;
            double tongtien;
            for (int i = 0; i < lvCTHD.Items.Count; i++)
            {
                int sl;
                sl = int.Parse(lvCTHD.Items[i].SubItems[2].Text);
                gia = double.Parse(lvCTHD.Items[i].SubItems[3].Text);
                tongtien = sl * gia;
                s += tongtien;
            }
            return s;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            hienthiMaNV();
            hienthiMaBan();
            hienthiMaMon();
            hienthiHD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktNhapHD() == true)
            {
                if (ktMaHD(txtMaHD.Text) == true)
                {
                    lvHoaDon.Items.Clear();
                    txtMaHD.Focus();
                    string maHD = txtMaHD.Text;
                    string maKH = txtMaKH.Text;
                    string tenNV = txtTenNV.Text;
                    string ngay = String.Format("{0:MM/dd/yyyy}", dateBan.Value);
                    ListViewItem lvi = lvHoaDon.Items.Add(maHD);
                    lvi.SubItems.Add(maKH);
                    lvi.SubItems.Add(cbbManv.SelectedValue.ToString());
                    lvi.SubItems.Add(cbbMaBan.SelectedValue.ToString());
                    lvi.SubItems.Add(ngay);
                }
            }
            lvCTHD.Items.Clear();
            btnThemCT.Enabled = true;
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
                    setNullHD();
                }
                hienthiHD();
                hienthiCTHD();
            }
            else
                MessageBox.Show("Chọn dòng cần xóa");
        }

        void suathongtinHD()
        {
            try
            {
                txtMaHD.ReadOnly = true;
                if (lvHoaDon.SelectedIndices.Count > 0)
                {
                    string ngay = String.Format("{0:MM/dd/yyyy}", dateBan.Value);
                    for (int i = 0; i < lvHoaDon.Items.Count; i++)
                    {
                        if (lvHoaDon.Items[i].Text == txtMaHD.Text)
                        {
                            lvHoaDon.Items[i].SubItems[1].Text = txtMaKH.Text;
                            lvHoaDon.Items[i].SubItems[2].Text = cbbManv.SelectedValue.ToString();
                            lvHoaDon.Items[i].SubItems[3].Text = cbbMaBan.SelectedValue.ToString();
                            lvHoaDon.Items[i].SubItems[4].Text = ngay;
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            suathongtinHD();
            string ngay = String.Format("{0:MM/dd/yyyy}", dateBan.Value);
            double tongtien = tinhtongTien();
            txtTongHD.Text = tongtien.ToString();
            ts.SuaHD(txtMaHD.Text, txtMaKH.Text, cbbManv.SelectedValue.ToString(), cbbMaBan.SelectedValue.ToString(), ngay, tongtien);
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hienthiHD();
            txtTongHD.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        void LuuHD()
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dateBan.Value);
            double tongtien = double.Parse(txtTongHD.Text);
            ts.ThemMoiHD(txtMaHD.Text, txtMaKH.Text, cbbManv.SelectedValue.ToString(), cbbMaBan.SelectedValue.ToString(), ngay, tongtien);
            MessageBox.Show("Lưu thành công");

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (themmoi)
            {
                LuuHD();
                for (int i = 0; i < lvCTHD.Items.Count; i++)
                {
                    string maMon = lvCTHD.Items[i].SubItems[0].Text;
                    string tenMon = lvCTHD.Items[i].SubItems[1].Text;
                    double gia = double.Parse(lvCTHD.Items[i].SubItems[2].Text.ToString());
                    int sl = int.Parse(lvCTHD.Items[i].SubItems[3].Text.ToString());
                    ts.ThemCTHD(txtMaHD.Text, maMon, tenMon, sl, gia);
                }
                lvCTHD.Items.Clear();
                setNullHD();
            }

            setButtons(true);
            hienthiHD();
            hienthiCTHD();
        }

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            setNullCTHD();
            setNullHD();
            setKhoaHD(true);
            setKhoaHD(true);
            setButtons(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
         }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSL.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSL.Focus();
                }
                else
                {
                    string sl = txtSL.Text;
                    string gia = txtGia.Text;

                    double tongtien = 0;
                    ListViewItem lvi = lvCTHD.Items.Add(cbbMaMon.SelectedValue.ToString());
                    lvi.SubItems.Add(txtTenMon.Text);
                    lvi.SubItems.Add(gia.ToString());
                    lvi.SubItems.Add(sl.ToString());
                    txtTongHD.Text = tinhtongTien().ToString();
                    MessageBox.Show("Thêm mới thành công");
                }
                setNullCTHD();
                setButtons(false);
                btnLuu.Enabled = true;
                btnKLuu.Enabled = true;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        void suathongtinCTHD()
        {
            try
            {
                if (lvCTHD.SelectedIndices.Count > 0)
                {
                    int sl = int.Parse(txtSL.Text);
                    double gia = double.Parse(txtGia.Text);
                    lvCTHD.SelectedItems[0].SubItems[0].Text = cbbMaMon.SelectedValue.ToString();
                    lvCTHD.SelectedItems[0].SubItems[1].Text = txtTenMon.Text;
                    lvCTHD.SelectedItems[0].SubItems[2].Text = sl.ToString();
                    lvCTHD.SelectedItems[0].SubItems[3].Text = gia.ToString();
                    tinhtongTien();
                    txtTongHD.Text = tinhtongTien().ToString();
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn thông tin cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            suathongtinCTHD();
            for (int i = 0; i < lvCTHD.Items.Count; i++)
            {
                string maMon = lvCTHD.Items[i].SubItems[0].Text;
                string tenMon = lvCTHD.Items[i].SubItems[1].Text;
                int sl = int.Parse(lvCTHD.Items[i].SubItems[2].Text);
                double gia = double.Parse(lvCTHD.Items[i].SubItems[3].Text);
                ts.SuaCTHD(txtMaHD.Text, maMon, tenMon, sl, gia, cbbMaMon.SelectedValue.ToString());
            }
            double a = tinhtongTien();
            txtTongHD.Text = a.ToString();

            setNullCTHD();
        }


        void HienThiTenNV(string maNV)
        {
            DataTable dt = ts.LayDsMaNV();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == maNV)
                {
                    txtTenNV.Text = dt.Rows[i][1].ToString();
                }
            }
        }

        void HienThiMonAn(string maMon)
        {
            DataTable dt = ts.LayDsMenu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == maMon)
                {
                    txtTenMon.Text = dt.Rows[i][1].ToString();
                    txtGia.Text = dt.Rows[i][3].ToString();
                }
            }
        }
        private void cbbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiMonAn(cbbMaMon.SelectedValue.ToString());

        }

        private void cbbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiTenNV(cbbManv.SelectedValue.ToString());
        }

        private void lvCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTHD.SelectedIndices.Count > 0)
            {
                cbbMaMon.Text = lvCTHD.SelectedItems[0].SubItems[0].Text;
                txtTenMon.Text = lvCTHD.SelectedItems[0].SubItems[1].Text;
                txtGia.Text = lvCTHD.SelectedItems[0].SubItems[3].Text;
                txtSL.Text = lvCTHD.SelectedItems[0].SubItems[2].Text;
            }
        }

        void hienthiCTHDtheoHD(string maHD)
        {
            lvCTHD.Items.Clear();
            DataTable dt = ts.LayDSCTHD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == maHD)
                {
                    ListViewItem lvi = lvCTHD.Items.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());

                }
            }
        }
        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.Items.Count > 0)
            {
                if (lvHoaDon.SelectedIndices.Count > 0)
                {
                    string maHD = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                    txtMaHD.Text = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                    txtMaKH.Text = lvHoaDon.SelectedItems[0].SubItems[1].Text;
                    cbbManv.SelectedIndex = cbbManv.FindString(lvHoaDon.SelectedItems[0].SubItems[2].Text);
                    cbbMaBan.SelectedIndex = cbbMaBan.FindString(lvHoaDon.SelectedItems[0].SubItems[3].Text);
                    dateBan.Value = DateTime.Parse(lvHoaDon.SelectedItems[0].SubItems[4].Text);
                    hienthiCTHDtheoHD(maHD);
                    double s = tinhtongTien();
                    txtTongHD.Text = s.ToString();
                }
            }
        }
    }
}
