using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TIENTRINH
    {
        private string mahv;
        private string ngaycheckup;
        private string cannang;
        private string chieucao;

        public string Mahv { get => mahv; set => mahv = value; }
        public string Ngaycheckup { get => ngaycheckup; set => ngaycheckup = value; }
        public string Cannang { get => cannang; set => cannang = value; }
        public string Chieucao { get => chieucao; set => chieucao = value; }
        public TIENTRINH(string mahv, string ngaycheckup, string cannang, string chieucao)
        {
            this.Mahv = mahv;
            this.Ngaycheckup = ngaycheckup;
            this.Cannang = cannang;
            this.Chieucao = chieucao;
        }
        public TIENTRINH(DataRow row)
        {
            this.Mahv = row["mahv"].ToString();
            this.Ngaycheckup = row["ngaycheckup"].ToString();
            this.Cannang = row["cannang"].ToString();
            this.Chieucao = row["chieucao"].ToString();

            
        }
    }
}
