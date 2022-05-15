using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoiVienDAO
    {
        public DataTable GetAllHoiVien()
        {
            string query = "SELECT * FROM HOIVIEN";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public HOIVIEN GetHoivienByID(int idDrink)
        {
            string query = "SELECT * FROM HOIVIEN WHERE mahv = @mahv";
            object[] value = new object[] { idDrink };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            HOIVIEN drink = new HOIVIEN(dt.Rows[0]);
            return drink;
        }

        public HOIVIEN GetHoivienByName(string name)
        {
            string query = "SELECT * FROM HOIVIEN WHERE hoten = @hoten";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            HOIVIEN drink = new HOIVIEN(dt.Rows[0]);
            return drink;
        }

        

        public DataTable GetAllHoivienDetailed()
        {
            string query = "SELECT HOIVIEN.mahv as mahv, HOIVIEN.hoten as hoten, HOIVIEN.phai as phai, HOIVIEN.hoten as Họ tên,  HOIVIEN.cannang as cannang, HOIVIEN.chieucao as chieucao, HOIVIEN.ngdangki as ngdangki, HOIVIEN.sdt as sdt";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public bool InsertHoivien(string mahv, string hoten, string phai, float cannang, float chieucao, string ngsinh, string ngdangki, string sdt)
        {
            string query = "insert into HOIVIEN(mahv, hoten, phai, cannang, chieucao, ngsinh, ngdangki, sdt, nvquanli) values(@mahv, @hoten, @phai, @cannang, @chieucao, @ngsinh, @ngdangki)";
            object[] value = new object[] { mahv, hoten, phai, cannang, chieucao, ngsinh, ngdangki, sdt };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool DeleteHoivien(string mahv)
        {
            string query = "delete from HOIVIEN where mahv = @mahv";
            object[] value = new object[] { mahv };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool UpdateHoivien(string mahv, string hoten, string phai, float cannang, float chieucao, string ngsinh, string ngdangki, string sdt)
        {
            string query = "update HOIVIEN set hoten = @hoten, phai = @phai, cannang = @cannang, chieucao = @chieucao, ngsinh = @ngsinh, ngdangki = @ngdangki, sdt = @sdt where mahv = @mahv";
            object[] value = new object[] { hoten, phai, cannang, chieucao, ngsinh, ngdangki, sdt, mahv};
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }

}
