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

    }
}
