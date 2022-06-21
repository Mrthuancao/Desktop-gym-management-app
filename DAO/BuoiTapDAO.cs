using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BuoiTapDAO
    {
        public DataTable GetName(string a)
        {
            string query = "SELECT DANGKY.mahv, hoten, sdt FROM HOIVIEN, DANGKY WHERE HOIVIEN.mahv = DANGKY.mahv  AND manv=@a";
            object[] value = new object[] { a };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public DataTable ShowCombox(string manv)
        {
            string query = "SELECT madk FROM DANGKY where manv=@manv ";
            object[] value = new object[] { manv } ;
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public string GetNameByMaDK(string madk)
        {
            string query = "SELECT hoten FROM DANGKY, HOIVIEN WHERE madk = @madk AND DANGKY.mahv=HOIVIEN.mahv";
            object[] value = new object[] { madk };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            string dk = dt.Rows[0]["hoten"].ToString();
            return dk;
        }
        public DataTable ShowDaTaGriWiew(string manv, string thoigian)
        {
            string query = "SELECT BUOITAP.madk, HOIVIEN.mahv, HOIVIEN.hoten, buoi, thoigian, tenbt FROM HOIVIEN, BUOITAP, DANGKY, BAITAP WHERE HOIVIEN.mahv = DANGKY.mahv AND DANGKY.madk = BUOITAP.madk AND BUOITAP.mabt = BAITAP.mabt AND manv=@manv AND thoigian=@thoigian";
            object[] value = new object[] { manv, thoigian };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public bool InsertBuoiTap(string madk, string buoi, string thoigian, string mabt)
        {
            string query = "insert into BUOITAP(madk, buoi, thoigian, mabt) values(@madk, @buoi, @thoigian, @mabt)";
            object[] value = new object[] { madk, buoi, thoigian, mabt};
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public bool DeleteDKBuoiTap(string madk, string thoigian)
        {
            string query = "delete from BUOITAP where BUOITAP.madk = @madk and thoigian=@thoigian";
            object[] value = new object[] { madk, thoigian };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public DataTable CountHV(string manv, string thoigian)
        {
            string query = "SELECT * FROM BUOITAP, DANGKY WHERE DANGKY.madk = BUOITAP.madk AND manv=@manv AND thoigian=@thoigian" ;
            object[] value = new object[] { manv,thoigian };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public DataTable MaDKRest(string manv, string thoigian)
        {
            string query = "Select madk from DANGKY WHERE manv=@manv except SELECT BUOITAP.madk FROM BUOITAP, DANGKY WHERE DANGKY.madk = BUOITAP.madk AND manv=@manv AND thoigian=@thoigian";
            object[] value = new object[] { manv, thoigian };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public string KiemTra(string madk, string thoigian)
        {
            string query = "SELECT madk FROM BUOITAP where madk=@madk and thoigian=@thoigian";
            object[] value = new object[] { madk, thoigian};
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            string a = dt.Rows.Count.ToString();
            return a;
        }
        public DataTable TenBaiTap()
        {
            string query = "SELECT mabt,tenbt from BAITAP";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
    }
}
