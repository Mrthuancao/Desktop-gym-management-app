using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DANGKY
    {
        private string madk;
        private string magoi;
        private string mahv;
        private string manv;
        private string thoigiandk;
        private string thoigiankt;

        public string Madk { get => madk; set => madk = value; }
        public string Magoi { get => magoi; set => magoi = value; }
        public string Mahv { get => mahv; set => mahv = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Thoigiandk { get => thoigiandk; set => thoigiandk = value; }
        public string Thoigiankt { get => thoigiankt; set => thoigiankt = value; }

        public DANGKY(string madk, string magoi, string mahv,string manv, string thoigiandk, string thoigiankt)
        {
            this.Madk = madk;  
            this.Magoi = magoi;
            this.Mahv = mahv;
            this.Manv = manv;
            this.Thoigiandk = thoigiandk;
            this.Thoigiankt = thoigiankt;
        }

        public DANGKY(DataRow row)
        {
            this.Madk = row["madk"].ToString();
            this.Magoi = row["magoi"].ToString();
            this.Mahv = row["mahv"].ToString();
            this.Manv = row["manv"].ToString();
            this.Thoigiandk = row["thoigiandk"].ToString();
            this.Thoigiankt = row["thoigiankt"].ToString();

        }
    }
    
}
