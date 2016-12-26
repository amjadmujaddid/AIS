using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class DetailPinjamWarkah
    {
        public string Nomorpjm { get; set; }
        public string NW_Barcode { get; set; }
        public int JumlahBK { get; set; }

        public virtual Warkah Warkah { get; set; }
        public virtual Pinjam Pinjam { get; set; }
    }
}
