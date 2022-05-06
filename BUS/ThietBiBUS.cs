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
    public class ThietBiBUS
    {
        ThietBiDAO ThietBiDAO = new ThietBiDAO();
        public List<THIETBI> GetThietBiList()
        {
            List<THIETBI> listThietBi = new List<THIETBI>();
            DataTable dt = ThietBiDAO.getAllEquipments();
            foreach (DataRow row in dt.Rows)
            {
                THIETBI ThietBi = new THIETBI(row);
                listThietBi.Add(ThietBi);
            }
            return listThietBi;
        }

        //public bool logIn(string username, string password)
        //{
        //    string Username = "";
        //    DataTable dt = ThietBiDAO.getLoginThietBi(username, getHashMD5(password).ToString());
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

        public THIETBI getEquipmentByName(string username)
        {
            THIETBI ThietBi = ThietBiDAO.getEquipmentByName(username);
            return ThietBi;
        }


        public THIETBI getEquipmentByID(string ID)
        {
            THIETBI ThietBi = ThietBiDAO.getEquipmentByID(ID);
            return ThietBi;
        }


        //public bool updatePassword(string username, string new_password)
        //{
        //    try
        //    {
        //        ThietBiDAO.updatePassword(username, getHashMD5(new_password).ToString());
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool insertEquipment(string tenThietBi, string maThietBi, DateTime ngayMua, DateTime ngaySuDung, DateTime hanBaoTri, int money, string maHang, string maLoaiThietBi, int soLuong)
        {
            try
            {
                ThietBiDAO.insertEquipment(tenThietBi, maThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maHang, maLoaiThietBi, soLuong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteEquipment(string username)
        {
            try
            {
                if (ThietBiDAO.deleteEquipment(username))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateEquipment(string tenThietBi, string maThietBi, DateTime ngayMua, DateTime ngaySuDung, DateTime hanBaoTri, int money, string maHang, string maLoaiThietBi, int soLuong)
        {
            try
            {
                return (ThietBiDAO.updateEquipment(tenThietBi, maThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maHang, maLoaiThietBi, soLuong));

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