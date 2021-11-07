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
    public partial class FrmMenu : Form
    {
        dbqltrasuauwu context = new dbqltrasuauwu();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            List<MENU> mENUs = context.MENUs.ToList();
            List<CTHD> cTHDs = context.CTHDs.ToList();
            txtmamonan.Focus();
            laydanhsachmenu(mENUs);
        }

        private void laydanhsachmenu(List<MENU> mENUs)
        {
            dgvbangmenu.Rows.Clear();
            foreach (var item in mENUs)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btntraicayep_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            danhsachmenutraicayep(menuts);
        }

        private void danhsachmenutraicayep(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts where s.MoTa == "traicayep" select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btncaphe_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            danhsachmenucafe(menuts);
        }

        private void danhsachmenucafe(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts where s.MoTa == "cafe" select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btnnuocngot_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            danhsachmenunuocngot(menuts);
        }

        private void danhsachmenunuocngot(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts where s.MoTa == "nuocngot" select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btnthucan_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            danhsachmenuthucanvat(menuts);
        }

        private void danhsachmenuthucanvat(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts where s.MoTa == "thucanvat" select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btntrasua_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            danhsachmenutrasua(menuts);
        }

        private void danhsachmenutrasua(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts where s.MoTa == "trasua" select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void dgvbangmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvbangmenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvbangmenu.CurrentRow.Selected = true;
                    txtmamonan.Text = dgvbangmenu.Rows[e.RowIndex].Cells["dgvMaMonAn"].FormattedValue.ToString();
                    txttenmonan.Text = dgvbangmenu.Rows[e.RowIndex].Cells["dgvTenMonAn"].FormattedValue.ToString();
                    txtmota.Text = dgvbangmenu.Rows[e.RowIndex].Cells["dgvMoTa"].FormattedValue.ToString();
                    txtdongia.Text = dgvbangmenu.Rows[e.RowIndex].Cells["dgvDonGia"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private bool checksoluongvamahoadon()
        {
            if (txtSoluong.Text == "" || txtmahoadon.Text == "" || txtmanv.Text == "" || txtdongia.Text == "" || txtmamonan.Text == "" || txtmota.Text == "" || txttenmonan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return false;
            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtSoluong.Text, out kq);
                if (!ketqua)
                {
                    MessageBox.Show("Số lượng chưa đúng!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void btnchonmon_Click(object sender, EventArgs e)
        {
            if (checksoluongvamahoadon())
            {
                CTHD cTHD = new CTHD();
                HOADON hOADON = new HOADON();
                hOADON.MaHoaDon = txtmahoadon.Text;
                hOADON.MANV = Convert.ToInt32(txtmanv.Text);
                cTHD.MaHoaDon = txtmahoadon.Text;
                cTHD.MaMonAn = txtmamonan.Text;
                cTHD.TenMonAn = txttenmonan.Text;
                cTHD.Soluong = Convert.ToInt32(txtSoluong.Text);
                cTHD.DonGia = Convert.ToInt32(txtdongia.Text);
                context.CTHDs.AddOrUpdate(cTHD);
                context.HOADONs.AddOrUpdate(hOADON);
                context.SaveChanges();

                loadDGV();

                loadform();
                MessageBox.Show($"thêm món ăn {cTHD.TenMonAn} vào hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                if (checkidMonAn(txtmamonan.Text) == -1)
                {
                    MENU mENU = new MENU();
                    mENU.MaMonAn = txtmamonan.Text;
                    mENU.TenMonAn = txttenmonan.Text;
                    mENU.MoTa = txtmota.Text;
                    mENU.MANV = Convert.ToInt32(txtmanv.Text);
                    mENU.DonGia = Convert.ToInt32(txtdongia.Text);

                    context.MENUs.AddOrUpdate(mENU);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"thêm món ăn {mENU.TenMonAn} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MENU mENU = new MENU();
                    mENU.MaMonAn = txtmamonan.Text;
                    mENU.TenMonAn = txttenmonan.Text;
                    mENU.MoTa = txtmota.Text;
                    mENU.DonGia = Convert.ToInt32(txtdongia.Text);

                    context.MENUs.AddOrUpdate(mENU);
                    context.SaveChanges();

                    loadDGV();

                    loadform();
                    MessageBox.Show($"chỉnh sửa món ăn {mENU.TenMonAn} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void loadDGV()
        {
            List<MENU> menuts = context.MENUs.ToList();
            laydanhsachmenu(menuts);
        }

        private void loadform()
        {
            
            txtmamonan.Clear();
            txttenmonan.Clear();
            txtmota.Clear();
            txtdongia.Clear();
            txtmanv.Clear();
            txtSoluong.Clear();
            txtmamonan.Focus();
        }

        private bool checkdatainput()
        {
            if (txtmamonan.Text == "" || txttenmonan.Text == "" || txtdongia.Text == "" || txtmota.Text == "" || txtmanv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn cần thêm");
                return false;
            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtdongia.Text, out kq);
                if (!ketqua)
                {
                    MessageBox.Show("đơn giá chưa đúng!", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        private int checkidMonAn(string idnewmonan)
        {
            int length = dgvbangmenu.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvbangmenu.Rows[i].Cells[0].Value != null)
                    if (dgvbangmenu.Rows[i].Cells[0].Value.ToString() == idnewmonan)
                        return i;
            }
            return -1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<MENU> menuts = context.MENUs.ToList();
            timmon(menuts);
        }

        private void timmon(List<MENU> menuts)
        {
            dgvbangmenu.Rows.Clear();
            var SearchTraSua = from s in menuts
                               where s.MaMonAn == txtmamonan.Text
              && s.TenMonAn == txttenmonan.Text
              && s.MoTa == txtmota.Text
              && s.DonGia == Convert.ToInt32(txtdongia.Text)
                               select s;
            foreach (var item in SearchTraSua)
            {
                int index = dgvbangmenu.Rows.Add();
                dgvbangmenu.Rows[index].Cells[0].Value = item.MaMonAn;
                dgvbangmenu.Rows[index].Cells[1].Value = item.TenMonAn;
                dgvbangmenu.Rows[index].Cells[2].Value = item.MoTa;
                dgvbangmenu.Rows[index].Cells[3].Value = item.DonGia;
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            reportmenu reportmenu = new reportmenu();
            reportmenu.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string idmonan = txtmamonan.Text;
            MENU deletemenu = context.MENUs.FirstOrDefault(p => p.MaMonAn == idmonan);
            if (deletemenu != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa món ăn{deletemenu.TenMonAn} không ?", "Thông báo cho bạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    context.MENUs.Remove(deletemenu);
                    context.SaveChanges();

                    loadform();
                    loadDGV();

                    MessageBox.Show($"Xóa {deletemenu.TenMonAn} thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}