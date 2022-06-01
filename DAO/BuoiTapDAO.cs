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
            string query = "SELECT HOIVIEN.hoten FROM HOIVIEN, BUOITAP, DANGKY WHERE HOIVIEN.mahv = DANGKY.mahv AND DANGKY.madk = BUOITAP.madk and DANGKY.madk=N'" + a + "'";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
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
            string query = "SELECT HOIVIEN.mahv, HOIVIEN.hoten, buoi FROM HOIVIEN, BUOITAP, DANGKY WHERE HOIVIEN.mahv = DANGKY.mahv AND DANGKY.madk = BUOITAP.madk AND manv=@manv AND thoigian=@thoigian";
            object[] value = new object[] { manv, thoigian };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public bool InsertBuoiTap(string madk, string buoi, string thoigian)
        {
            string query = "insert into BUOITAP(madk, buoi, thoigian) values(@madk, @buoi, @thoigian)";
            object[] value = new object[] { madk, buoi, thoigian };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public bool DeleteDKBuoiTap(string madk)
        {
            string query = "delete from BUOITAP where madk = @madk";
            object[] value = new object[] { madk };
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

    }
}
