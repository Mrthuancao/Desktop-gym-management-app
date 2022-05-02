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
            string query = "SELECT HOIVIEN.mahv as Mã Hội viên, HOIVIEN.hoten as Họ tên, HOIVIEN.phai as Giới tính, HOIVIEN.ngsinh as Ngày sinh, HOIVIEN.ngdangki as Ngày đăng kí, HOIVIEN.sdt as SDT, HOIVIEN.nvquanli as Mã nhân viên PT";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public bool InsertHoivien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            string query = "insert into HOIVIEN(mahv, hoten, phai, ngsinh, ngdangki, sdt, nvquanli) values(@mahv, @hoten, @phai, @ngsinh, @ngdangki, @sdt, @nvquanli)";
            object[] value = new object[] { mahv, hoten, phai, ngsinh, ngdangki, sdt, nvquanli };
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

        public bool UpdateHoivien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            string query = "update HOIVIEN set hoten = @hoten, phai = @phai, ngsinh = @ngsinh, ngdangki = @ngdangki, sdt = @sdt, nvquanli = @nvquanli where mahv = @mahv";
            object[] value = new object[] { hoten, phai, ngsinh, ngdangki, sdt, nvquanli, mahv};
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }

}
