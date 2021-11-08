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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }


        private void mENUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMenu frm = this.MdiChildren.OfType<FrmMenu>().FirstOrDefault();
            if (frm == null)
            {
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.MdiParent = this;
                frmMenu.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bÀNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = this.MdiChildren.OfType<frmBan>().FirstOrDefault();
            if (frm == null)
            {
                frmBan frmBan = new frmBan();
                frmBan.MdiParent = this;
                frmBan.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        

        private void dOANHTHUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = this.MdiChildren.OfType<frmDoanhThu>().FirstOrDefault();
            if (frm == null)
            {
                frmDoanhThu frmDoanhThu = new frmDoanhThu();
                frmDoanhThu.MdiParent = this;
                frmDoanhThu.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = this.MdiChildren.OfType<frmHoaDon>().FirstOrDefault();
            if (frm == null)
            {
                frmHoaDon frmHoaDon = new frmHoaDon();
                frmHoaDon.MdiParent = this;
                frmHoaDon.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = this.MdiChildren.OfType<frmNhanVien>().FirstOrDefault();
            if (frm == null)
            {
                frmNhanVien frmNhanVien = new frmNhanVien();
                frmHoaDon.MdiParent = this;
                frmNhanVien.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = this.MdiChildren.OfType<frmkhachhang>().FirstOrDefault();
            if (frm == null)
            {
                frmkhachhang frmkhachhang = new frmkhachhang();
                frmkhachhang.MdiParent = this;
                frmkhachhang.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void vỀCHÚNGTÔIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvechungtoi frm = this.MdiChildren.OfType<frmvechungtoi>().FirstOrDefault();
            if (frm == null)
            {
                frmvechungtoi frmvechungtoi = new frmvechungtoi();
                frmvechungtoi.MdiParent = this;
                frmvechungtoi.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
    }
}
