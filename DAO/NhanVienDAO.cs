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
        public DataTable GetAllNhanVien()
        {
            string query = "SELECT manv, hoten, phai, ngsinh,ngvaolam,sdt,email,luong,NHANVIEN.malnv,tenlnv FROM NHANVIEN, LOAINHANVIEN WHERE NHANVIEN.malnv=LOAINHANVIEN.malnv";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetLNV()
        {
            string query = "SELECT * FROM LOAINHANVIEN";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }


        public NHANVIEN GetNhanVienByID(string ID)
        {
            string query = "select * from NHANVIEN where manv = @ID";
            object[] value = new object[] { ID };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            NHANVIEN nhanVien = new NHANVIEN(dt.Rows[0]);
            return nhanVien;
        }

        public List<NHANVIEN> SearchNhanVienByName(string hoten)
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            string query = string.Format("SELECT * FROM dbo.NHANVIEN WHERE dbo.fuConvertToUnsign1(hoten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", hoten);
            object[] value = new object[] {hoten};
            DBConnect db = new DBConnect();
            DataTable data = db.ExecuteQuery(query, value);
            foreach (DataRow item in data.Rows)
            {
                NHANVIEN nv = new NHANVIEN(item);
                list.Add(nv);
            }

            return list;
        }

        public bool InsertNhanVien(string hoTen, string maNhanVien, string phai, string ngaySinh, string ngayVaoLam, string soDienThoai, string email, decimal luong, string maLoaiNhanVien)
        {
            string query = "insert into NHANVIEN( hoten, manv, phai, ngsinh, ngvaolam, sdt, email, luong, malnv ) values(@hoTen, @maNhanVien, @phai, @ngaySinh, @ngayVaoLam, @soDienThoai, @email, @luong, @maLoaiNhanVien )";
            object[] value = new object[] { hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool DeleteNhanVien(string name)
        {
            string query = "delete from NHANVIEN where hoten = @name";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool UpdateNhanVien (string maNhanVien, string hoTen, string phai, string ngaySinh, string ngayVaoLam, string soDienThoai, string email, decimal luong, string maLoaiNhanVien)
        {
            string query = "update NHANVIEN set hoten = @hoTen, phai = @phai, ngsinh = @ngaySinh, ngvaolam = @ngayVaoLam, sdt = @soDienThoai, email = @email, luong = @luong, malnv = @maLoaiNhanVien where manv = @maNhanVien";
            object[] value = new object[] { hoTen, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien, maNhanVien };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public DataTable GetManvPT()
        {
            string query = "SELECT manv,hoten FROM NHANVIEN WHERE malnv='PT'";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetManvPTORNull()
        {
            string query = "SELECT manv,hoten FROM NHANVIEN WHERE malnv='PT' OR malnv is null";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
        public DataTable GetManvHVDK()
        {
            string query = "SELECT NV.manv, NV.hoten FROM NHANVIEN NV, DANGKY DK WHERE NV.manv = DK.manv AND NV.manv <> 'NV000' AND NV.malnv = 'PT' GROUP BY NV.Manv, NV.hoten HAVING COUNT(*) <6";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }
    }

}
