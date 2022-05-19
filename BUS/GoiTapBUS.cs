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
    public class GoiTapBus
    {
        GoiTapDAO GoiTapDAO = new GoiTapDAO();
        
        public DataTable GetAllGoiTap(string a)
        {
            return GoiTapDAO.GetAllGoiTap(a);
        }
        public DataTable GetAllGoiTapDetail()
        {
            return GoiTapDAO.GetAllGoiTapDetail();
        }
        public bool InsertGoiTap(string madk, string magoi, string mahv, string manv, string thoigiandk, string thoigiankt)
        {
            return GoiTapDAO.InsertGoiTap(madk,magoi, mahv,manv, thoigiandk, thoigiankt);
        }
        public DataTable ShowDaTaGriWiew()
        {
            return GoiTapDAO.ShowDaTaGriWiew();
        }
        
        public DataTable ShowCombox()
        {
            return GoiTapDAO.ShowCombox();
        }
        /*public bool DeleteGoiTap(int magoi)
        {
            return GoiTapDAO.DeleteGoiTap(magoi);
        }

        public bool UpdateGoiTap(int magoi, string tengoi, int giamoithang, char coPT)
        {
            return GoiTapDAO.UpdateGoiTap(magoi, tengoi, giamoithang, coPT);
        }*/
    }
}

