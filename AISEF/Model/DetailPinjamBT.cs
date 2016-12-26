using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class DetailPinjamBT
    {
        public string Nomorpjm { get; set; }
        public string NB_Barcode { get; set; }
        public int JumlahBK { get; set; }

        public virtual BukuTanah BukuTanah { get; set; }
        public virtual Pinjam Pinjam { get; set; }
    }
}
