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
    public partial class frmDoanhThu : Form
    {
        TraSua ts = new TraSua();
        long tongDoanhThu;
        
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public long TongDoanhThuHomNay()
        {
            tongDoanhThu = 0;
            long tongtien = 0;
            DataTable dt = ts.LayDSHoaDonChoDoanhThuHomNay();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = long.Parse(dt.Rows[i][5].ToString());
                tongDoanhThu += tongtien;
            }
            return tongDoanhThu;
        }
        void HienThiLístViewHomNay()
        {
            lsvDoanhThu.Items.Clear();
            DataTable dt = ts.LayDSHoaDonChoDoanhThuHomNay();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =

                lsvDoanhThu.Items.Add(dt.Rows[i][0].ToString());

                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HienThiLístViewHomNay();
            long totalDoanhThuHomNay = TongDoanhThuHomNay();
            txtTongDoanhThu.Text = totalDoanhThuHomNay.ToString();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        void HienThiListViewTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy}", dtpDenNgay.Value);
            lsvDoanhThu.Items.Clear();
            DataTable dt = ts.LayDSHoaDonChoDoanhThuTuNgayDenNgay(tuNgay, denNgay);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =

                lsvDoanhThu.Items.Add(dt.Rows[i][0].ToString());

                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        public long TongDoanhThuTungayDenNgay()
        {
            string tuNgay = String.Format("{0:MM/dd/yyyy}", dtpTuNgay.Value);
            string denNgay = String.Format("{0:MM/dd/yyyy}", dtpDenNgay.Value);
            tongDoanhThu = 0;
            long tongtien = 0;
            DataTable dt = ts.LayDSHoaDonChoDoanhThuTuNgayDenNgay(tuNgay,denNgay);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongtien = long.Parse(dt.Rows[i][5].ToString());
                tongDoanhThu += tongtien;
            }
            return tongDoanhThu;
        } 
        private void btnCheck_Click(object sender, EventArgs e)
        {
            HienThiListViewTungayDenNgay();
            long totalDoanhThu = TongDoanhThuTungayDenNgay();
            txtTongDoanhThu.Text = totalDoanhThu.ToString();
        }
    }
}
