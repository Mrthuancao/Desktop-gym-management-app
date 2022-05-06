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
    public class NhanVienDAO
    {
        public DataTable getAllEmployees()
        {
            string query = "SELECT * FROM NHANVIEN";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public NHANVIEN getEmployeeByName(string name)
        {
            string query = "select * from NHANVIEN where hoten = @name";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            NHANVIEN nhanVien = new NHANVIEN(dt.Rows[0]);
            return nhanVien;
        }

        public NHANVIEN getEmployeeByID(string ID)
        {
            string query = "select * from NHANVIEN where manv = @ID";
            object[] value = new object[] { ID };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            NHANVIEN nhanVien = new NHANVIEN(dt.Rows[0]);
            return nhanVien;
        }

        public bool insertEmployee(string hoTen, string maNhanVien, bool phai, DateTime ngaySinh, DateTime ngayVaoLam, string soDienThoai, string email, int luong, string maLoaiNhanVien)
        {
            string query = "insert into NHANVIEN( hoten, manv, phai, ngsinh, ngvaolam, sdt, email, luong, malnv ) values(@hoTen, @maNhanVien, @phai, @ngaySinh, @ngayVaoLam, @soDienThoai, @email, @luong, @maLoaiNhanVien )";
            object[] value = new object[] { hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool deleteEmployee(string name)
        {
            string query = "delete from NHANVIEN where hoten = @name";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateEmployee (string hoTen, string maNhanVien, bool phai, DateTime ngaySinh, DateTime ngayVaoLam, string soDienThoai, string email, int luong, string maLoaiNhanVien)
        {
            string query = "update NHANVIEN set hoten = @hoTen, phai = @phai, ngsinh = @ngaySinh, ngvaolam = @ngayVaoLam, sdt = @soDienThoai, email = @email, luong = @luong, malnv = @maLoaiNhanVien where manv = @maNhanVien";
            object[] value = new object[] { hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien };
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
