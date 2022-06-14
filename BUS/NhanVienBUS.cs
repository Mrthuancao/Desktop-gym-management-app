using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO NhanVienDAO = new NhanVienDAO();
        public List<NHANVIEN> GetNhanVienList()
        {
            List<NHANVIEN> listNhanVien = new List<NHANVIEN>();
            DataTable dt = NhanVienDAO.GetAllNhanVien();
            foreach (DataRow row in dt.Rows)
            {
                NHANVIEN nhanVien = new NHANVIEN(row);
                listNhanVien.Add(nhanVien);
            }
            return listNhanVien;
        }

        

        public List<NHANVIEN> GetNhanVienByName(string name)
        {
            return NhanVienDAO.SearchNhanVienByName(name);
        }


        public NHANVIEN GetNhanVienByID(string id)
        {
            NHANVIEN NhanVien = NhanVienDAO.GetNhanVienByID(id);
            return NhanVien;
        }
        public DataTable GetAllNV()
        {
            return NhanVienDAO.GetAllNhanVien();
        }

       

        public bool InsertNhanVien(string hoTen, string maNhanVien, string phai, string ngaySinh, string ngayVaoLam, string soDienThoai, string email, decimal luong, string maLoaiNhanVien)
        {
            try
            {
                NhanVienDAO.InsertNhanVien(hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool DeleteNhanVien(string username)
        {
            try
            {
                if (NhanVienDAO.DeleteNhanVien(username))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateNhanVien(string maNhanVien, string hoTen, string phai, string ngaySinh, string ngayVaoLam, 
            string soDienThoai, string email, decimal luong, string maLoaiNhanVien)
        {
            return (NhanVienDAO.UpdateNhanVien(maNhanVien, hoTen, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien));
        }

        //public StringBuilder getHashMD5(string pass)
        //{
        //    MD5 hash = MD5.Create();
        //    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
        //    byte[] outputBytes = hash.ComputeHash(inputBytes);
        //    StringBuilder hash_str = new StringBuilder();
        //    for (int i = 0; i < outputBytes.Length; i++)
        //    {
        //        hash_str.Append(outputBytes[i].ToString("x2"));
        //    }
        //    return hash_str;
        //}
        public DataTable GetManvPT()
        {
            return NhanVienDAO.GetManvPT();
        }
        public DataTable GetLNV()
        {
            return NhanVienDAO.GetLNV();
        }
        public DataTable GetManvPTORNull()
        {
            return NhanVienDAO.GetManvPTORNull();
        }
        public DataTable GetManvHVDK()
        {
            return NhanVienDAO.GetManvHVDK();
        }
    }
}