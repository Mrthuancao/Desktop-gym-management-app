using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichTrinhDAO
    {
        public DataTable GetAllLT(string a, string b)
        {
            string query = "SELECT ngaycheckup, cannang, chieucao FROM DANGKY,TIENTRINH WHERE DANGKY.mahv = TIENTRINH.mahv AND manv=@a AND TIENTRINH.mahv=@b ORDER BY ngaycheckup DESC";
            object[] value = new object[] { a,b };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }
        public bool InsertLichTrinh(string mahv, string ngaycheckup, string cannang, string chieucao)
        {
            string query = "insert into TIENTRINH(mahv, ngaycheckup, cannang, chieucao) values(@mahv, @ngaycheckup, @cannang, @chieucao)";
            object[] value = new object[] { mahv, ngaycheckup, cannang, chieucao };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }
}
