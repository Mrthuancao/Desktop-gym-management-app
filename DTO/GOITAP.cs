using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GOITAP
    {
        private string magoi;
        private string tengoi;
        private string giamoithang;
        private string coPT;

        public string Magoi { get => magoi; set => magoi = value; }
        public string Tengoi { get => tengoi; set => tengoi = value; }
        public string Giamoithang { get => giamoithang; set => giamoithang = value; }
        public string CoPT { get => coPT; set => coPT = value; }

        public GOITAP(string magoi, string tengoi, string giamoithang, string coPT)
        {
            this.Magoi = magoi; 
            this.Tengoi = tengoi;
            this.Giamoithang = giamoithang;
            this.CoPT = coPT;
        }
        public GOITAP(DataRow row)
        {
            this.Magoi = row["magoi"].ToString();
            this.Tengoi = row["tengoi"].ToString();
            this.Giamoithang = row["giamoithang"].ToString();
            this.CoPT = row["coPT"].ToString();
        }

    }
}
