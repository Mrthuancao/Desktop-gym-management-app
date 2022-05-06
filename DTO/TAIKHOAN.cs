using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TAIKHOAN
    {
        private string matk;
        private string username;
        private string pass;
        private string manv;

        public string Matk { get => matk; set => matk = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Manv { get => manv; set => manv = value; }

        public TAIKHOAN(string matk, string username, string pass, string manv)
        {
            this.Matk = matk;
            this.Username = username;
            this.Pass = pass;
            this.Manv = manv;
        }

        public TAIKHOAN(DataRow row)
        {
            this.Matk = row["matk"].ToString();
            this.Username = row["username"].ToString();
            this.Pass = row["pass"].ToString();
            this.Manv = row["manv"].ToString();
        }
    }
}
