using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public DataTable getAllSanPham()
        {
            string query = "SELECT * FROM SANPHAM";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public SANPHAM getSanPhamByName(string name)
        {
            string query = "select * from SANPHAM where tensp = @name";
            object[] value = new object[] { name };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            SANPHAM sp = new SANPHAM(dt.Rows[0]);
            return sp;
        }

        public SANPHAM getSanPhamByID(string ID)
        {
            string query = "select * from SANPHAM where masp = @ID";
            object[] value = new object[] { ID };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            SANPHAM sp = new SANPHAM(dt.Rows[0]);
            return sp;
        }

        public bool insertSanPham(string masp, string tensp, decimal gianhap, decimal dongia, int soluong, string ngaymua, string malsp)
        {
            string query = "insert into SANPHAM(masp, tensp, gianhap, dongia, soluong, ngaymua, malsp) values(@masp, @tensp, @gianhap, @dongia, @soluong, @ngaymua, @malsp)";
            object[] value = new object[] { masp, tensp, gianhap, dongia, soluong, ngaymua, malsp };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool deleteSanPham(string masp)
        {
            string query = "delete from SANPHAM where masp = @masp";
            object[] value = new object[] { masp };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateSanPham(string masp, string tensp, decimal gianhap, decimal dongia, int soluong, string ngaymua, string malsp)
        {
            string query = "update SANPHAM set tensp = @tensp, gianhap = @gianhap, dongia = @dongia, soluong = @soluong, ngaymua = @ngaymua, malsp = @malsp where masp = @masp";
            object[] value = new object[] { tensp, gianhap, dongia, soluong, ngaymua, malsp, masp};
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public List<SANPHAM> SearchSanPhamByName(string tensp)
        {
            List<SANPHAM> list = new List<SANPHAM>();
            string query = string.Format("SELECT * FROM dbo.SANPHAM WHERE dbo.fuConvertToUnsign1(tensp) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", tensp);
            object[] value = new object[] { tensp };
            DBConnect db = new DBConnect();
            DataTable data = db.ExecuteQuery(query, value);
            foreach (DataRow item in data.Rows)
            {
                SANPHAM sp = new SANPHAM(item);
                list.Add(sp);
            }

            return list;
        }
    }
}
