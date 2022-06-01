using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BUOITAP
    {
        private string madk;
        private string buoi;
        private string thoigian;

        public string Madk { get => madk; set => madk = value; }
        public string Buoi { get => buoi; set => buoi = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public BUOITAP(string madk, string buoi, string thoigian)
        {
            this.Madk = madk;
            this.Buoi = buoi;
            this.Thoigian = thoigian;
        }
        public BUOITAP(DataRow row)
        {
            this.Madk = row["madk"].ToString();
            this.Buoi = row["buoi"].ToString();
            this.Thoigian = row["thoigian"].ToString();

        }
    }
}
