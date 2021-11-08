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
    public partial class reportkhachhang : Form
    {
        dbQLtrasuauwu context = new dbQLtrasuauwu();
        public reportkhachhang()
        {
            InitializeComponent();
        }

        private void reportkhachhang_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> kHACHHANGs = context.KHACHHANGs.ToList();
            reportViewer1.Visible = false;
            dodulieucbb(kHACHHANGs);
            this.reportViewer1.RefreshReport();
        }

        private void dodulieucbb(List<KHACHHANG> kHACHHANGs)
        {
            this.cbbmakhachhang.DataSource = kHACHHANGs;
            this.cbbmakhachhang.DisplayMember = "MaKhachHang";
        }

        private void btnintheoma_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            KHACHHANG idkHACHHANG = context.KHACHHANGs.FirstOrDefault(p => p.MaKhachHang == cbbmakhachhang.Text);
            List<KHACHHANG> listkh = context.KHACHHANGs.Where(p => p.MaKhachHang == cbbmakhachhang.Text).ToList();

            if (idkHACHHANG == null || listkh.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào");
                return;
            }

            this.reportViewer1.LocalReport.ReportPath = "./report/Reportkhachhang.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", listkh);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void btnintatca_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            List<KHACHHANG> kHACHHANGs = context.KHACHHANGs.ToList();
            this.reportViewer1.LocalReport.ReportPath = "./report/Reportkhachhang.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", kHACHHANGs);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
