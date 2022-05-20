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



        public bool insertEquipment(string maThietBi , string tenThietBi, string ngayMua, string ngaySuDung, string hanBaoTri, decimal money, string maLoaiThietBi, int soLuong)
        {
            try
            {
                ThietBiDAO.insertEquipment(maThietBi, tenThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maLoaiThietBi, soLuong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteEquipment(string matb)
        {
            try
            {
                if (ThietBiDAO.deleteEquipment(matb))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateEquipment(string maThietBi, string tenThietBi, string ngayMua, string ngaySuDung, string hanBaoTri, decimal money, string maLoaiThietBi, int soLuong)
        {
            try
            {
                return (ThietBiDAO.updateEquipment(maThietBi, tenThietBi, ngayMua, ngaySuDung, hanBaoTri, money, maLoaiThietBi, soLuong));

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<THIETBI> SearchThietBiByName(string tenthietbi)
        {
            return ThietBiDAO.SearchThietBiByName(tenthietbi);
        }


    }
}