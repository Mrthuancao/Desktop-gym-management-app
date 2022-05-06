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
        public List<NHANVIEN> GetEmployeesList()
        {
            List<NHANVIEN> listNhanVien = new List<NHANVIEN>();
            DataTable dt = NhanVienDAO.getAllEmployees();
            foreach (DataRow row in dt.Rows)
            {
                NHANVIEN nhanVien = new NHANVIEN(row);
                listNhanVien.Add(nhanVien);
            }
            return listNhanVien;
        }

        //public bool logIn(string username, string password)
        //{
        //    string Username = "";
        //    DataTable dt = NhanVienDAO.getLoginNhanVien(username, getHashMD5(password).ToString());
        //    if (dt != null)
        //    {
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            Username = row["Username"].ToString();
        //        }
        //    }
        //    if (Username != "")
        //        return true;
        //    return false;
        //}

        public NHANVIEN getEmployeeByName(string name)
        {
            NHANVIEN NhanVien = NhanVienDAO.getEmployeeByName(name);
            return NhanVien;
        }


        public NHANVIEN getEmployeeByID(string id)
        {
            NHANVIEN NhanVien = NhanVienDAO.getEmployeeByID(id);
            return NhanVien;
        }


        //public bool updatePassword(string username, string new_password)
        //{
        //    try
        //    {
        //        NhanVienDAO.updatePassword(username, getHashMD5(new_password).ToString());
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool insertEmployee(string hoTen, string maNhanVien, bool phai, DateTime ngaySinh, DateTime ngayVaoLam, string soDienThoai, string email, int luong, string maLoaiNhanVien)
        {
            try
            {
                NhanVienDAO.insertEmployee(hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteEmployee(string username)
        {
            try
            {
                if (NhanVienDAO.deleteEmployee(username))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateEmployee(string hoTen, string maNhanVien, bool phai, DateTime ngaySinh, DateTime ngayVaoLam, string soDienThoai, string email, int luong, string maLoaiNhanVien)
        {
            try
            {
                return (NhanVienDAO.updateEmployee(hoTen, maNhanVien, phai, ngaySinh, ngayVaoLam, soDienThoai, email, luong, maLoaiNhanVien));

            }
            catch (Exception)
            {
                return false;
            }
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
    }
}