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

        public HOIVIEN GetHoivienByID(int idD)
        {
            string query = "SELECT * FROM HOIVIEN WHERE mahv = @mahv";
            object[] value = new object[] { idD };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            HOIVIEN hv = new HOIVIEN(dt.Rows[0]);
            return hv;
        }

        public List<HOIVIEN> SearchHoiVienByName(string hoten)
        {
            List<HOIVIEN> list = new List<HOIVIEN>();
            string query = string.Format("SELECT * FROM dbo.HOIVIEN WHERE dbo.fuConvertToUnsign1(hoten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", hoten);
            object[] value = new object[] { hoten };
            DBConnect db = new DBConnect();
            DataTable data = db.ExecuteQuery(query, value);
            foreach (DataRow item in data.Rows)
            {
                HOIVIEN hv = new HOIVIEN(item);
                list.Add(hv);
            }

            return list;
        }



        public DataTable GetAllHoivienDetailed()
        {
            string query = "SELECT HOIVIEN.mahv as mahv, HOIVIEN.hoten as hoten, HOIVIEN.phai as phai, HOIVIEN.hoten as hoten,  HOIVIEN.ngdangki as ngdangki, HOIVIEN.sdt as sdt from HOIVIEN";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public bool InsertHoivien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt)
        {
            string query = "insert into HOIVIEN(mahv, hoten, phai, ngsinh, ngdangki, sdt) values(@mahv, @hoten, @phai, @ngsinh, @ngdangki, @sdt)";
            object[] value = new object[] { mahv, hoten, phai, ngsinh, ngdangki, sdt };
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

        public bool UpdateHoivien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt)
        {
            string query = "update HOIVIEN set hoten = @hoten, phai = @phai, ngsinh = @ngsinh, ngdangki = @ngdangki, sdt = @sdt where mahv = @mahv";
            object[] value = new object[] { hoten, phai, ngsinh, ngdangki, sdt, mahv};
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }

}
