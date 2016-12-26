using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class BukuTanah
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BukuTanah()
        {
            this.DetailKembaliBTs = new HashSet<DetailKembaliBT>();
            this.DetailPinjamBTs = new HashSet<DetailPinjamBT>();
        }

        public string RecordStatus { get; set; }
        public string NB_Barcode { get; set; }
        public string IDHak { get; set; }
        public string NomorHak { get; set; }
        public string No_Album { get; set; }
        public string IDDesa { get; set; }
        public string IDKecamatan { get; set; }
        public int Luas { get; set; }
        public string PemegangHak { get; set; }
        public string Status { get; set; }

        public virtual Album Album { get; set; }
        public virtual Desa Desa { get; set; }
        public virtual JenisHak JenisHak { get; set; }
        public virtual Kecamatan Kecamatan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKembaliBT> DetailKembaliBTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPinjamBT> DetailPinjamBTs { get; set; }
    }
}
