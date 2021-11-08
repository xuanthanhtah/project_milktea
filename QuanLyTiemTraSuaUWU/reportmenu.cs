using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQLTraSua.dataAcessLayer.models;
using Microsoft.Reporting.WinForms;

namespace QuanLyTiemTraSuaUWU
{
    public partial class reportmenu : Form
    {
        dbQLtrasuauwu context = new dbQLtrasuauwu();
        public reportmenu()
        {
            InitializeComponent();
        }

        private void reportmenu_Load(object sender, EventArgs e)
        {
            List<MENU> mENUs = context.MENUs.ToList();
            rpvmenu.Visible = false;
            //addCbbmamonan(mENUs);
            this.rpvmenu.RefreshReport();
        }

        private void btnintatca_Click(object sender, EventArgs e)
        {
            rpvmenu.Visible = true;
            List<MENU> mENUs = context.MENUs.ToList();
            this.rpvmenu.LocalReport.ReportPath = "./report/Reportmenu.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetmenu", mENUs);
            rpvmenu.LocalReport.DataSources.Clear();
            rpvmenu.LocalReport.DataSources.Add(reportDataSource);
            this.rpvmenu.RefreshReport();
        }

        private void btnintheoma_Click(object sender, EventArgs e)
        {
            rpvmenu.Visible = true;
            MENU idmenu = context.MENUs.FirstOrDefault(p => p.MoTa == cbbmamonan.Text);
            List<MENU> listmenu = context.MENUs.Where(p => p.MoTa == cbbmamonan.Text).ToList();

            if (idmenu == null || listmenu.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy món ăn nào");
                return;
            }

            this.rpvmenu.LocalReport.ReportPath = "./report/Reportmenu.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetmenu", listmenu);
            this.rpvmenu.LocalReport.DataSources.Clear();
            this.rpvmenu.LocalReport.DataSources.Add(reportDataSource);
            this.rpvmenu.RefreshReport();
        }
    }
}
