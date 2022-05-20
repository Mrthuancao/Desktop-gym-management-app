using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THIETBI
    {
        private string matb;
        private string tenthietbi;
        private string ngmua;
        private string ngsd;
        private string hanbaotri;
        private decimal gia;
        private string maltb;
        private int soluong;

        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public string Matb { get => matb; set => matb = value; }
        public string Ngmua { get => ngmua; set => ngmua = value; }
        public string Ngsd { get => ngsd; set => ngsd = value; }
        public string Hanbaotri { get => hanbaotri; set => hanbaotri = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string Maltb { get => maltb; set => maltb = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public THIETBI(string matb, string tenthietbi,  string ngmua, string ngsd, string hanbaotri, decimal gia, string maltb, int soluong)
        {
            this.Matb = matb;
            this.Tenthietbi = tenthietbi;
            this.Ngmua = ngmua;
            this.Ngsd = ngsd;
            this.Hanbaotri = hanbaotri;
            this.Gia = gia;
            this.Maltb = maltb;
            this.Soluong = soluong;
        }
        public THIETBI(DataRow row)
        {
            this.Matb = row["matb"].ToString();
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Ngmua = row["ngmua"].ToString();
            this.Ngsd = row["ngsd"].ToString();
            this.Hanbaotri = row["hanbaotri"].ToString();
            this.Gia = (decimal)row["gia"];
            this.Maltb = row["maltb"].ToString();
            this.Soluong = (int)row["soluong"];
        }
    }
}
