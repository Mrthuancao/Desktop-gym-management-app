using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SANPHAM
    {
        private string masp;
        private string tensp;
        private decimal gianhap;
        private decimal dongia;
        private int soluong;
        private string ngaymua;
        private string malsp;

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public decimal Gianhap { get => gianhap; set => gianhap = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Ngaymua { get => ngaymua; set => ngaymua = value; }
        public string Malsp { get => malsp; set => malsp = value; }

        public SANPHAM(string masp, string tensp, decimal gianhap, decimal dongia, int soluong, string ngaymua, string malsp)
        {
            this.Masp = masp;
            this.Tensp = tensp;
            this.Gianhap = gianhap;
            this.Dongia = dongia;
            this.Soluong = soluong;
            this.Ngaymua = ngaymua;
            this.Malsp = malsp;
        }

        public SANPHAM(DataRow row)
        {
            this.Masp = row["masp"].ToString();
            this.Tensp = row["tensp"].ToString();
            this.Gianhap = (decimal)row["gianhap"];
            this.Dongia = (decimal)row["dongia"];
            this.Soluong = (int)row["soluong"];
            this.Ngaymua = row["ngaymua"].ToString();
            this.Malsp = row["malsp"].ToString();
        }    
    }
}
