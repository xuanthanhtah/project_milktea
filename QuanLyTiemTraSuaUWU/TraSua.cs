using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTiemTraSuaUWU
{
    class TraSua
    {
        public static bool trung = false;
        Database db;
        public TraSua()
        {
            db = new Database();
        }

        public DataTable LayDSBanDangSD()
        {
            string strSQL = "select MaBan from ban where TrangThai = N'ĐangSD'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        public DataTable LayDSChuaSD()
        {
            string sql = "select MaBan from BAN where TrangThai = N'ChưaSD'";
            DataTable dt = db.Execute(sql);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        
        
        public void ThemBan(string maban)
        {

               string sql = string.Format("INSERT INTO BAN VALUES(N'{0}',N'ChưaSD')", maban);
               db.ExecuteNonQuery(sql);
        }
        public void XoaBan(string maban)
        {

            string sql = string.Format("Update BAN SET TrangThai=N'Đã Hủy' WHERE MABAN=N'{0}'", maban);
            db.ExecuteNonQuery(sql);

        }
        public void LeftToRight(string maban)
        {
            string sql = string.Format("Update BAN SET TrangThai=N'ĐangSD' WHERE MABAN=N'{0}'", maban);
            db.ExecuteNonQuery(sql);
        }
        public void RightToLeft(string maban)
        {
            string sql = string.Format("Update BAN SET TrangThai=N'ChưaSD' WHERE MABAN=N'{0}'", maban);
            db.ExecuteNonQuery(sql);
        }
        public DataTable LayTatCaBan()
        {
            string strSQL = "select * from BAN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }

        public DataTable LayDSHoaDon()
        {
            string strSQL = "select *from HOADON";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }

        public DataTable LayDSCTHD()
        {
            string strSQL = "select *from CTHD";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }


        //thêm thông tin vào CTHD
        public void ThemMoiHD(string maHD, string MaKhachHang, string MANV, string MaBan, string ngayban, double tongtien)
        {
            string sql = string.Format("INSERT INTO HOADON VALUES('{0}','{1}','{2}',N'{3}','{4}',{5})"
                 , maHD, MaKhachHang, MANV, MaBan, ngayban, tongtien);
            db.ExecuteNonQuery(sql);
        }

        //thêm thông tin vào CTHD
        public void ThemCTHD(string MaHD, string maMonAn, string TenMonAn, int sl, double gia)
        {
            string sql = string.Format("INSERT INTO CTHD VALUES('{0}','{1}', N'{2}', {3}, {4})"
                 , MaHD, maMonAn, TenMonAn, sl, gia);
            db.ExecuteNonQuery(sql);
        }

        //sửa thông tin hóa đơn
        public void SuaHD(string maHD, string MaKhachHang, string MANV, string MaBan, string ngayban, double tongtien)
        {
            string str = string.Format("Update HOADON set MaKhachHang = '{0}', MANV = '{1}',MaBan = N'{2}', NgayXuatHoaDon = '{3}',Tongtien = {4} where MaHoaDon ='{5}'"
                 , MaKhachHang, MANV, MaBan, ngayban, tongtien, maHD);
            db.ExecuteNonQuery(str);
        }

        //sửa thông tin chi tiết hóa đơn
        public void SuaCTHD(string maHD, string MaMon, string tenMon, int sl, double gia, string maMon)
        {
            string str = string.Format("Update CTHD set MaMonAn = '{0}', TenMonAn = N'{1}', Soluong = {2}, DonGia = {3} where MaHoaDon = '{4}' and MaMonAn = '{5}'"
                 , MaMon, tenMon, sl, gia, maHD, MaMon);
            db.ExecuteNonQuery(str);
        }

        public DataTable LayDsMaNV()
        {
            string strSQL = "select *from NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }

        public DataTable LayDsMenu()
        {
            string strSQL = "select *from MENU";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }

        public DataTable LayDsMaBan()
        {
            string strSQL = "select *from BAN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        public DataTable LayDsMaMon()
        {
            string strSQL = "select *from MENU";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        // xóa thông tin mã món ăn trong cthd
        public void xoaMaMonAnCTHD(string maHoaDon)
        {
            string sql = string.Format("Delete from CTHD where MaHoaDon='{0}' ", maHoaDon);
            db.ExecuteNonQuery(sql);
        }

        //Xóa Hóa đơn
        public void xoaHoaDon(string maHoaDon)
        {
            xoaMaMonAnCTHD(maHoaDon);
            string sql = string.Format("Delete from HoaDon where MaHoaDon='{0}' ", maHoaDon);
            db.ExecuteNonQuery(sql);
        }

        // tìm kiếm hóa đơn theo mã
        public DataTable timHoaDon(string maHoaDon)
        {
            string sql = string.Format("Select *from HoaDon where MaHoaDon ='{0}'", maHoaDon);
            DataTable dt = db.Execute(sql);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        public void ThemDangKy(string gioitinh, string machucvu,string taikhoan,string matkhau)
        {
            string sql = string.Format("insert into NHANVIEN(GioiTinh,MaChucVu,TaiKhoan,MatKhau) values(N'{0}','{1}','{2}','{3}')",
                                    gioitinh, machucvu, taikhoan, matkhau);
            db.ExecuteNonQuery(sql);
        }

        public DataTable LayDSHoaDonChoDoanhThuHomNay()
        {
            DateTime now = DateTime.Now;
            string ngay = String.Format("{0:MM/dd/yyyy}",now);
            string sql = string.Format("select * from HOADON where NgayXuatHoaDon= '{0}'",ngay);
            DataTable dt = db.Execute(sql);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
        public DataTable LayDSHoaDonChoDoanhThuTuNgayDenNgay(string tungay,string denngay)
        {
            string sql = string.Format("select * from HOADON where NgayXuatHoaDon between '{0}' and '{1}'",tungay,denngay);
            DataTable dt = db.Execute(sql);
            //Goi phuong thuc truy xuat DL
            return dt;
        }
    }
}
