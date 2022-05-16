using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN
    {
        private string manv;
        private string hoten;
        private string phai;
        private string ngsinh;
        private string ngvaolam;
        private string sdt;
        private string email;
        private decimal luong;
        private string malnv;


        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Ngsinh { get => ngsinh; set => ngsinh = value; }
        public decimal Luong { get => luong; set => luong = value; }
        public string Ngvaolam { get => ngvaolam; set => ngvaolam = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Malnv { get => malnv; set => malnv = value; }

        public NHANVIEN(string manv, string hoten, string phai, string ngsinh, int luong, string ngvaolam, string sdt, string email, string malnv)
        {
            this.Manv = manv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Ngsinh = ngsinh;
            this.Luong = luong;
            this.Ngvaolam = ngvaolam;
            this.Sdt = sdt;
            this.Email = email;
            this.Malnv = malnv;
        }
        public NHANVIEN(DataRow row)
        {
            this.Manv = row["manv"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Phai = row["phai"].ToString();
            this.Ngsinh = row["ngsinh"].ToString();
            this.Luong = (decimal)row["luong"];
            this.Ngvaolam = row["ngvaolam"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString();
            this.Malnv = row["malnv"].ToString();
        }
    }
}
