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
        private string mabt;

        public string Madk { get => madk; set => madk = value; }
        public string Buoi { get => buoi; set => buoi = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Mabt { get => mabt; set => mabt = value; }

        public BUOITAP(string madk, string buoi, string thoigian, string mabt)
        {
            this.Madk = madk;
            this.Buoi = buoi;
            this.Thoigian = thoigian;
            this.Mabt = mabt;
        }
        public BUOITAP(DataRow row)
        {
            this.Madk = row["madk"].ToString();
            this.Buoi = row["buoi"].ToString();
            this.Thoigian = row["thoigian"].ToString();
            this.Mabt = row["mabt"].ToString();

        }
    }
}
