using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HoiVienBUS
    {
        HoiVienDAO hvDAL = new HoiVienDAO();
        public List<HOIVIEN> GetHoiVienList()
        {
            List<HOIVIEN> listHoiVien = new List<HOIVIEN>();
            DataTable dt = hvDAL.GetAllHoiVien();
            foreach (DataRow row in dt.Rows)
            {
                HOIVIEN hoivien = new HOIVIEN(row);
                listHoiVien.Add(hoivien);
            }
            return listHoiVien;
        }
        public DataTable GetAllHoivienDetailed()
        {
            return hvDAL.GetAllHoivienDetailed();
        }

        public bool InsertHoiVien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt)
        {
            return hvDAL.InsertHoivien(mahv, hoten, phai, ngsinh, ngdangki, sdt);
        }

        public bool DeleteHoiVien(string mahv)
        {
            return hvDAL.DeleteHoivien(mahv);
        }

        public bool UpdateHoiVien(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt)
        {
            return hvDAL.UpdateHoivien(mahv, hoten, phai, ngsinh, ngdangki, sdt);
        }

        public List<HOIVIEN> SearchHoiVienByName(string name)
        {
            return hvDAL.SearchHoiVienByName(name);
        }
        public DataTable GetAllHoiVien()
        {
            return hvDAL.GetAllHoiVien();
        }
        public DataTable GetAllHVNotNull()
        {
            return hvDAL.GetAllHVNotNull();
        }
        public DataTable GetAllRest()
        {
            return hvDAL.GeTAllRest();
        }
    }
}
