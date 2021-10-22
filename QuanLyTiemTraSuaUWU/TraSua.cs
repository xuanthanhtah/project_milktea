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
        // xóa thông tin mã món ăn trong cthd
        public void xoaMaMonAnCTHD(string maHoaDon)
        {
            string sql = string.Format("Delete from CTHD where MaHoaDon='{0}' ", maHoaDon);
            db.ExecuteNonQuery(sql);
        }

        //from hóa đơn

        //lấy thông tin hóa đơn
        public DataTable LayDSHoaDon()
        {
            string sql = "SELECT hd.MaHoaDon,MaKhachHang,MANV,MaBan,NgayXuatHoaDon,Tongtien ,*FROM dbo.HOADON hd, dbo.CTHD ct WHERE hd.MaHoaDon= ct.MaHoaDon ";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        // lấy thông tin bàn ăn
        public DataTable LayDsBan()
        {
            string sql = "SELECT *FROM BAN";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        //thêm thông tin vào danh sách hóa đơn
        public void ThemHoaDon(string maHD, string maKH, int maNV, string maBan, string ngayXuatHD, double tongtien)
        {
            string sql = string.Format("INSERT INTO HOADON VALUES('{0}','{1}',(2},N'{3}','{4}',{5})"
                 , maHD, maKH, maNV, maBan, ngayXuatHD, tongtien);
            db.ExecuteNonQuery(sql);
        }

        // cập nhật thông tin hóa đơn
        public void suaHoaDon(string maHD, string maKH, int maNV, string maBan, string ngayXuatHD, double tongtien)
        {
            string sql = string.Format("Update HOADON set MaKhachHang='{0},MANV='{1},MaBan=N'{2}',NgayXuatHoaDon=N'{3}',Tongtien ='{4}',where MaHoaDon ='{5}')"
              , maKH, maNV, maBan, ngayXuatHD, tongtien, maHD);
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
    }
}
