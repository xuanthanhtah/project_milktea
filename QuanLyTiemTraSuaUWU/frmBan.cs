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
        public frmBan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            chklsbBanTrong.Items.Add(txtNhapTenBan.Text);
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if (chklsbBanTrong.GetItemChecked(i))
                    chklsbBanTrong.Items.RemoveAt(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbBanTrong.Items.Count; i++)
            {
                if(chklsbBanTrong.GetItemChecked(i))
                {
                    chklsbBanDangSD.Items.Add(chklsbBanTrong.Items[i]);
                    chklsbBanDangSD.Items.RemoveAt(i);
                }    
            }

            for (int i = 0; i < chklsbBanDangSD.Items.Count; i++)
            {
                chklsbBanDangSD.SetItemChecked(i, true);
            }

            for (int i = 0; i < chklsbBanDangSD.Items.Count; i++)
            {
                if (chklsbBanDangSD.SelectedIndex == i)
                {
                    chklsbBanTrong.Items.Add(chklsbBanDangSD.Items[i]);
                    chklsbBanDangSD.Items.RemoveAt(i);
                }    

            }
        }
    }
}
