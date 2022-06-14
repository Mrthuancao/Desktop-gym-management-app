using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        public List<SANPHAM> GetSanPhamList()
        {
            List<SANPHAM> listThietBi = new List<SANPHAM>();
            DataTable dt = spDAO.getAllSanPham();
            foreach (DataRow row in dt.Rows)
            {
                SANPHAM SanPham = new SANPHAM(row);
                listThietBi.Add(SanPham);
            }
            return listThietBi;
        }
        public DataTable GetSP()
        {
            return spDAO.getAllSanPham();
        }
        public DataTable GetTenlsp()
        {
            return spDAO.GetTenlsp();
        }
        public string Tenlsp(string malsp)
        {
            return spDAO.Tenlsp(malsp);
        }



        public SANPHAM getSanPhamByName(string name)
        {
            SANPHAM SanPham = spDAO.getSanPhamByName(name);
            return SanPham;
        }


        public SANPHAM getSanPhamByID(string ID)
        {
            SANPHAM SanPham = spDAO.getSanPhamByID(ID);
            return SanPham;
        }



        public bool insertSanPham(string masp, string tensp, decimal gianhap, decimal dongia, int soluong, string ngaymua, string malsp)
        {
            try
            {
                spDAO.insertSanPham(masp, tensp, gianhap, dongia, soluong, ngaymua, malsp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteSanPham(string masp)
        {
            try
            {
                if (spDAO.deleteSanPham(masp))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateSanPham(string masp, string tensp, decimal gianhap, decimal dongia, int soluong, string ngaymua, string malsp)
        {
            try
            {
                return (spDAO.updateSanPham(masp, tensp, gianhap, dongia, soluong, ngaymua, malsp));

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<SANPHAM> SearchSanPhamByName(string tensp)
        {
            return spDAO.SearchSanPhamByName(tensp);
        }
    }
}
