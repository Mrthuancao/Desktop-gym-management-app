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
        public bool DeleteDKBuoiTap(string madk)
        {
            return BuoiTapDAO.DeleteDKBuoiTap(madk);
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
            int dem= 0;
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
    }


}
