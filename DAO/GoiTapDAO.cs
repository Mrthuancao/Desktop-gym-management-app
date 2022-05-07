using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GoiTapDAO
    {
        public DataTable GetAllGoiTap()
        {
            string query = "SELECT * FROM GOITAP";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public GOITAP GetGoiTapByID(int IDmagoi)
        {
            string query = "SELECT * FROM GOITAP WHERE magoi = @IDmagoi";
            object[] value = new object[] { IDmagoi };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            GOITAP magoi = new GOITAP(dt.Rows[0]);
            return magoi;
        }

        public GOITAP GetGoiTapByName(string Ntengoi)
        {
            string query = "SELECT * FROM GOITAP WHERE tengoi = @Ntengoi";
            object[] value = new object[] { Ntengoi };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            GOITAP tengoi = new GOITAP(dt.Rows[0]);
            return tengoi;
        }

        public DataTable GetAllGoiTapDetail()
        {
            string query = "SELECT GOITAP.magoi as Mã gói , GOITAP.tengoi as Tên, GOITAP.giamoithang as Giá, GOITAP.coPT as Có Personal Trainer";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public bool InsertGoiTap(int magoi, string tengoi, int giamoithang, char coPT)
        {
            string query = "insert into GOITAP(magoi, tengoi, giamoithang, coPT) values(@magoi, @tengoi, @giamoithang, @coPT)";
            object[] value = new object[] { magoi, tengoi, giamoithang, coPT };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        public bool DeleteGoiTap(int magoi)
        {
            string query = "delete from GOITAP where magoi = @magoi";
            object[] value = new object[] { magoi };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool UpdateGoiTap(int magoi, string tengoi, int giamoithang, char coPT)
        {
            string query = "update GOITAP set tengoi = @tengoi, giamoithang = @giamoithang, coPT = @coPT where magoi = @magoi";
            object[] value = new object[] { tengoi, giamoithang, coPT, tengoi };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }
}
