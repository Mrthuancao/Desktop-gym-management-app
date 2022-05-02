using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOIVIEN
    {
        private string mahv;
        private string hoten;
        private string phai;
        private string ngsinh;
        private string ngdangki;
        private string sdt;
        private string nvquanli;

        public string Mahv { get => mahv; set => mahv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Ngsinh { get => ngsinh; set => ngsinh = value; }
        public string Ngdangki { get => ngdangki; set => ngdangki = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Nvquanli { get => nvquanli; set => nvquanli = value; }

        public HOIVIEN(string mahv, string hoten, string phai, string ngsinh, string ngdangki, string sdt, string nvquanli)
        {
            this.Mahv = mahv;
            this.Hoten = hoten;
            this.Phai = phai;
            this.Ngsinh = ngsinh;
            this.Ngdangki = ngdangki;
            this.Sdt = sdt;
            this.Nvquanli = nvquanli;
        }
        public HOIVIEN(DataRow row)
        {
            this.Mahv = row["mahv"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Phai = row["phai"].ToString();
            this.Ngsinh = row["ngsinh"].ToString();
            this.Ngdangki = row["ngdangki"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Nvquanli = row["nvquanli"].ToString();

        }
    }
}
