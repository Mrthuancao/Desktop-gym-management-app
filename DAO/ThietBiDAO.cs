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
            THIETBI account = new THIETBI(dt.Rows[0]);
            return account;
        }

        public THIETBI getEquipmentByID(string ID)
        {
            string query = "select * from THIETBI where matb = @ID";
            object[] value = new object[] { ID };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            THIETBI account = new THIETBI(dt.Rows[0]);
            return account;
        }

        public bool insertEquipment(string tenThietBi, string maThietBi, DateTime ngayMua, DateTime ngaySuDung, DateTime hanBaoTri, int money, string maHang, string maLoaiThietBi, int soLuong)
        {
            string query = "insert into THIETBI(tenthietbi, matb, ngmua, ngsd, hanbaotri, gia, mahang, maltb, soluong) values(@tenThietBi, @maThietBi, @ngayMua, @ngaySuDung, @hanBaoTri, @money, @maHang, @maLoaiThietBi, @soLuong)";
            object[] value = new object[] { tenThietBi, maThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maHang, maLoaiThietBi, soLuong };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool deleteEquipment(string tenThietBi)
        {
            string query = "delete from THIETBI where tenthietbi = @tenThietBi";
            object[] value = new object[] { tenThietBi };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateEquipment(string tenThietBi, string maThietBi, DateTime ngayMua, DateTime ngaySuDung, DateTime hanBaoTri, int money, string maHang, string maLoaiThietBi, int soLuong)
        {
            string query = "update Account set tentb = @tenThietBi, ngmua = @ngayMua, ngsd = @ngaySuDung, hanbaotri = @hanBaoTri, gia = @money, mahang = @maHang, maltb = @maLoaiThietBi, soluong = @soLuong where matb = @maThietBi";
            object[] value = new object[] { tenThietBi, maThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maHang, maLoaiThietBi, soLuong };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        //public string getPasswordByUsername(string username)
        //{
        //    string password;
        //    string query = "select Password from Account where Username = @username";
        //    object[] value = new object[] { username };
        //    DBConnect db = new DBConnect();
        //    DataTable dt = db.ExecuteQuery(query, value);
        //    password = dt.Rows[0]["password"].ToString();
        //    return password;
        //}

        //// doi password tai khoan
        //public bool updatePassword(string username, string new_password)
        //{
        //    string query = "update ACCOUNT set Password = @password where Username = @username";
        //    object[] value = new object[] { new_password, username };
        //    DBConnect db = new DBConnect();
        //    return ((db.ExecuteNonQuery(query, value)) > 0);
        //}
    }

}
