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
        public List<GOITAP> GetGoiTapList()
        {
            List<GOITAP> listGoiTap = new List<GOITAP>();
            DataTable dt = GoiTapDAO.GetAllGoiTap();
            foreach (DataRow row in dt.Rows)
            {
                GOITAP goitap = new GOITAP(row);
                listGoiTap.Add(goitap);
            }
            return listGoiTap;
        }
        public DataTable GetAllGoiTapDetail()
        {
            return GoiTapDAO.GetAllGoiTapDetail();
        }
        public bool InsertGoiTap(int magoi, string tengoi, int giamoithang, char coPT)
        {
            return GoiTapDAO.InsertGoiTap(magoi, tengoi, giamoithang, coPT);
        }

        public bool DeleteGoiTap(int magoi)
        {
            return GoiTapDAO.DeleteGoiTap(magoi);
        }

        public bool UpdateGoiTap(int magoi, string tengoi, int giamoithang, char coPT)
        {
            return GoiTapDAO.UpdateGoiTap(magoi, tengoi, giamoithang, coPT);
        }
    }
}

