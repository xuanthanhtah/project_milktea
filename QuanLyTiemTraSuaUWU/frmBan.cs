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
    public partial class frmBan : Form
    {
        TraSua ts = new TraSua();
        public frmBan()
        {
            InitializeComponent();
        }
        void HienThiBanChuaSD()
        {
            chklsbBanTrong.Items.Clear();
            DataTable dt = ts.LayDSChuaSD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chklsbBanTrong.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        void HienThiBanDangSD()
        {
            chklsbBanDangSD.Items.Clear();
            DataTable dt = ts.LayDSBanDangSD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chklsbBanDangSD.Items.Add(dt.Rows[i][0].ToString());
            }
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            ts.ThemBan(txtNhapTenBan.Text);
            MessageBox.Show("Thêm Bàn Thành Công");
            HienThiBanChuaSD();
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.SelectedIndex== i)
                {
                    ts.XoaBan(chklsbBanTrong.Items[i].ToString());
                    MessageBox.Show("Xóa Bàn Thành Công");
                }
            }
            HienThiBanChuaSD();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanDangSD.Items.Count; i++)
            {
                chklsbBanDangSD.SetItemChecked(i, true);
            }
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            HienThiBanChuaSD();
            HienThiBanDangSD();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chklsbBanTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
