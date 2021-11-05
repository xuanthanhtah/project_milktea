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
    public partial class frmvechungtoi : Form
    {
        dbqltrasuauwu context = new dbqltrasuauwu();
        public frmvechungtoi()
        {
            InitializeComponent();
        }

        private void frmvechungtoi_Load(object sender, EventArgs e)
        {
            //reportViewer1.Visible = true;
            this.reportViewer1.LocalReport.ReportPath = "./report/reportvechungtoi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }
    }
}
