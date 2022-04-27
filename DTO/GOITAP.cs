using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class GOITAP
    {
        private char magoi;
        private char tengoi;
        private char giamoithang;
        private char coPT;

        public char Magoi { get => magoi; set => magoi = value; }
        public char Tengoi { get => tengoi; set => tengoi = value; }
        public char Giamoithang { get => giamoithang; set => giamoithang = value; }
    }
}
