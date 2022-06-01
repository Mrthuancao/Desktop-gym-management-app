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
        private string Type;


        public string Matk { get => matk; set => matk = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Type1 { get => Type; set => Type = value; }

        public TAIKHOAN(string matk, string username, string pass, string manv, string Type)
        {
            this.Matk = matk;
            this.Username = username;
            this.Pass = pass;
            this.Manv = manv;
            this.Type1 = Type;
            
        }

        public TAIKHOAN(DataRow row)
        {
            this.Matk = row["matk"].ToString();
            this.Username = row["username"].ToString();
            this.Pass = row["pass"].ToString();
            this.Manv = row["manv"].ToString();
            this.Type1 = row["Type"].ToString();
        }
    }
}
