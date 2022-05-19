using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GoiTapDAO
    {
        public DataTable GetAllGoiTap(string a)
        {   
            string query = "SELECT madk, HOIVIEN.mahv, HOIVIEN.hoten, DANGKY.thoigiankt, DANGKY.manv, giamoithang FROM HOIVIEN, GOITAP, DANGKY WHERE HOIVIEN.mahv = DANGKY.mahv AND DANGKY.magoi = GOITAP.magoi and tengoi=N'" + a + "'";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
        

        public DataTable ShowCombox()
        {
            string query = "SELECT * FROM GOITAP";
            object[] value = new object[] {};
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public DataTable ShowDaTaGriWiew()
        {
            string query = "SELECT HOIVIEN.mahv, HOIVIEN.hoten, DANGKY.thoigiankt, DANGKY.manv, giamoithang FROM HOIVIEN, GOITAP, DANGKY WHERE HOIVIEN.mahv = DANGKY.mahv AND DANGKY.magoi = GOITAP.magoi";
            object[] value = new object[] {};
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetAllGoiTapDetail()
        {
            string query = "SELECT DANGKY.madk as Mã đăng kí , DANGKY.magoi as Mã gói, DANGKY.mahv as Mã hội viên, DANGKY.manv as Mã nhân viên, DANGKY.thoigiandk as Thời gian đăng kí, DANGKY.as Thời gian kết thúc FROM DANGKY";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public bool InsertGoiTap(string madk, string magoi, string mahv, string manv, string thoigiandk, string thoigiankt)
        {
            string query = "insert into DANGKY(madk, magoi, mahv, manv, thoigiandk, thoigiankt) values(@madk, @magoi, @mahv,@manv, @thoigiandk, @thoigiankt)";
            object[] value = new object[] { madk, magoi, mahv, manv, thoigiandk, thoigiankt };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public bool DeleteDKGoiTap(string madk)
        {
            string query = "delete from DANGKY where madk = @madk";
            object[] value = new object[] { madk };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }



    }
}
