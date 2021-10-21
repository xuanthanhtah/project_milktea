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
        bool kt; int dem;
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
        bool KiemTraTrung(string maban)
        {
            DataTable dt = ts.LayTatCaBan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == maban)
                    return true;
            }
            return false;
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
        int ktrachuoi(string s)
        {
             /* Khai bao mot chuoi */
            int dem = 0;
            foreach (char chr in s)
            {
                dem += 1;

            }
            return dem;
        }
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            kt = KiemTraTrung(txtNhapTenBan.Text);
            dem = ktrachuoi(txtNhapTenBan.Text);
            if (dem > 10)
            {
                MessageBox.Show("Tên Bàn không quá 10 ký tự");
            }    
            
            else if (txtNhapTenBan.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên bàn");
            }

            else if (kt == true)
            {
                ts.RightToLeft(txtNhapTenBan.Text);
                HienThiBanChuaSD();
            }
            else
            {
                ts.ThemBan(txtNhapTenBan.Text);
                MessageBox.Show("Thêm Bàn Thành Công");
                HienThiBanChuaSD();
            }
            txtNhapTenBan.Text = "";
            txtNhapTenBan.Focus();
            
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.SelectedIndex==i)
                {
                    DialogResult ret = MessageBox.Show("Bạn có chắc muốn xóa không ?",
                        "Thông Báo",
                        MessageBoxButtons.YesNo);
                    if(ret==DialogResult.Yes)
                    {
                        ts.XoaBan(chklsbBanTrong.Items[i].ToString());
                        chklsbBanTrong.Items.RemoveAt(i);
                        HienThiBanChuaSD();
                    }    
                    
                    
                }
            }
            //HienThiBanChuaSD();
            
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
            /* for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
             {
                 if (chklsbBanTrong.GetItemChecked(i))
                 {
                     chklsbBanDangSD.Items.Add(chklsbBanTrong.Items[i]);
                     chklsbBanTrong.Items.RemoveAt(i);
                 }
             }*/
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.GetItemChecked(i))
                {
                    ts.LeftToRight(chklsbBanTrong.Items[i].ToString());
                    chklsbBanTrong.Items.RemoveAt(i);
                    HienThiBanDangSD();
                }
                
            }
        }

        private void chklsbBanDangSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanDangSD.Items.Count; i++)
            {
                if(chklsbBanDangSD.SelectedIndex==i)
                {
                    ts.RightToLeft(chklsbBanDangSD.Items[i].ToString());
                    chklsbBanDangSD.Items.RemoveAt(i);
                    HienThiBanChuaSD();
                }
            }
        }
    }
}
