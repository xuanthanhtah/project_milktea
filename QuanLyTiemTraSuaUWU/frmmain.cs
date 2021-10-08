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

        private void frmmain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmmain_Click(object sender, EventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
