using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        public DataTable getAllAccounts()
        {
            string query = "SELECT * FROM TAIKHOAN";
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query);
            return dt;
        }

        public TAIKHOAN getAccountByUsername(string username)
        {
            string query = "select * from TAIKHOAN where username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            TAIKHOAN account = new TAIKHOAN(dt.Rows[0]);
            return account;
        }
        public DataTable getLoginAccount(string username, string pass)
        {
            string query = "select * from TAIKHOAN where username = @username and pass = @pass";
            object[] value = new object[] { username, pass };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            return dt;
        }

        public bool insertAccount(string matk, string username, string pass, string manv)
        {
            string query = "insert into TAIKHOAN(matk, username, pass, manv) values(@matk, @username, @pass, @manv)";
            object[] value = new object[] { matk, username, pass, manv };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool deleteAccount(string username)
        {
            string query = "delete from TAIKHOAN where username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }

        public bool updateAccount(string matk, string username, string pass)
        {
            string query = "update TAIKHOAN set username = @username, pass = @pass where matk = @matk";
            object[] value = new object[] { username, pass, matk };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
        
        // truy van toi username trong table Accout
        public string getPasswordByUsername(string username)
        {
            string password;
            string query = "select pass from TAIKHOAN where username = @username";
            object[] value = new object[] { username };
            DBConnect db = new DBConnect();
            DataTable dt = db.ExecuteQuery(query, value);
            password = dt.Rows[0]["pass"].ToString();
            return password;
        }

        // doi password tai khoan
        public bool updatePassword(string username, string new_password)
        {
            string query = "update TAIKHOAN set password = @new_password where username = @username";
            object[] value = new object[] { new_password, username };
            DBConnect db = new DBConnect();
            return ((db.ExecuteNonQuery(query, value)) > 0);
        }
    }
}
