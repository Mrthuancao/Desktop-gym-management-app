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
            List<HOIVIEN> listDrink = new List<HOIVIEN>();
            DataTable dt = hvDAL.GetAllHoiVien();
            foreach (DataRow row in dt.Rows)
            {
                HOIVIEN drink = new HOIVIEN(row);
                listDrink.Add(drink);
            }
            return listDrink;
        }
        public DataTable GetAllDrinksDetailed()
        {
            return hvDAL.GetAllHoivienDetailed();
        }

        public bool InsertDrink(string mahv, string hoten, string phai, float cannang, float chieucao, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            return hvDAL.InsertHoivien(mahv, hoten, phai, cannang, chieucao, ngsinh, ngdangki, sdt, nvquanli);
        }

        public bool DeleteDrink(string mahv)
        {
            return hvDAL.DeleteHoivien(mahv);
        }

        public bool UpdateDrink(string mahv, string hoten, string phai, float cannang, float chieucao, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            return hvDAL.UpdateHoivien(mahv, hoten, phai, cannang, chieucao, ngsinh, ngdangki, sdt, nvquanli);
        }
    }
}
