using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class ThietBiDAO
    {
        public DataTable getAllEquipments()
        {
            string query = "SELECT * FROM THIETBI";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public THIETBI getEquipmentByName(string name)
        {
            string query = "select * from THIETBI where tenthietbi = @name";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            THIETBI tb = new THIETBI(dt.Rows[0]);
            return tb;
        }

        public THIETBI getEquipmentByID(string ID)
        {
            string query = "select * from THIETBI where matb = @ID";
            object[] value = new object[] { ID };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            THIETBI tb = new THIETBI(dt.Rows[0]);
            return tb;
        }

        public bool insertEquipment(string maThietBi , string tenThietBi, string ngayMua, string ngaySuDung, string hanBaoTri, decimal money, string maLoaiThietBi, int soLuong)
        {
            string query = "insert into THIETBI(matb, tenthietbi, ngmua, ngsd, hanbaotri, gia, maltb, soluong) values(@maThietBi, @tenThietBi, @ngayMua, @ngaySuDung, @hanBaoTri, @money, @maLoaiThietBi, @soLuong)";
            object[] value = new object[] { maThietBi, tenThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maLoaiThietBi, soLuong };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool deleteEquipment(string matb)
        {
            string query = "delete from THIETBI where matb = @matb";
            object[] value = new object[] { matb };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateEquipment(string maThietBi, string tenThietBi, string ngayMua, string ngaySuDung, string hanBaoTri, decimal money, string maLoaiThietBi, int soLuong)
        {
            string query = "update THIETBI set tenthietbi = @tenThietBi, ngmua = @ngayMua, ngsd = @ngaySuDung, hanbaotri = @hanBaoTri, gia = @money, maltb = @maLoaiThietBi, soluong = @soLuong where matb = @maThietBi";
            object[] value = new object[] { tenThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maLoaiThietBi, soLuong, maThietBi };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public List<THIETBI> SearchThietBiByName(string tenthietbi)
        {
            List<THIETBI> list = new List<THIETBI>();
            string query = string.Format("SELECT * FROM dbo.THIETBI WHERE dbo.fuConvertToUnsign1(tenthietbi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", tenthietbi);
            object[] value = new object[] { tenthietbi };
            DBConnect db = new DBConnect();
            DataTable data = db.ExecuteQuery(query, value);
            foreach (DataRow item in data.Rows)
            {
                THIETBI tb = new THIETBI(item);
                list.Add(tb);
            }

            return list;
        }
    }

}
