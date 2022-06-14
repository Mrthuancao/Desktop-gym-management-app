using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class BuoiTapBUS
    {
        BuoiTapDAO BuoiTapDAO = new BuoiTapDAO();
        public DataTable GetName(string a)
        {
            return BuoiTapDAO.GetName(a);
        }
        public DataTable ShowCombox(string a)
        {
            return BuoiTapDAO.ShowCombox(a);
        }
        public DataTable ShowDaTaGriWiew(string manv, string thoigian)
        {   
            return BuoiTapDAO.ShowDaTaGriWiew(manv, thoigian);
        }
        public bool InsertBuoiTap(string madk, string buoi, string thoigian)
        {
            return BuoiTapDAO.InsertBuoiTap(madk, buoi, thoigian);
        }
        public bool DeleteDKBuoiTap(string madk, string thoigian)
        {
            return BuoiTapDAO.DeleteDKBuoiTap(madk, thoigian);
        }
        public string GetNameByMaDK(string a)
        {
            try
            {
                return BuoiTapDAO.GetNameByMaDK(a);
            }
            catch (Exception)
            {
                return null;
            }

        }
        public int CountHV(string manv, string thoigian)
        {
            int dem = 0;
            DataTable dt = BuoiTapDAO.CountHV(manv, thoigian);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dem++;
                }
            }
            return dem;
        }
        public DataTable MaDKRest(string manv, string thoigian)
        {
            return BuoiTapDAO.MaDKRest(manv, thoigian);
        }
        public int KiemTra(string madk, string thoigian)
        {
            if (BuoiTapDAO.KiemTra(madk, thoigian) == "1")
                return 1;
            else
                return 0;
        }

    }


}
