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
    public class LichTrinhBUS
    {
        LichTrinhDAO ltDAO = new LichTrinhDAO();
        public DataTable GetAllLt(string manv, string mahv)
        {
            return ltDAO.GetAllLT(manv, mahv);
        }
        public bool InsertLichTrinh(string mahv, string ngaycheckup, string cannang, string chieucao)
        {
            return ltDAO.InsertLichTrinh(mahv, ngaycheckup, cannang, chieucao);
        }
    }
}
