using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Warkah
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warkah()
        {
            this.DetailPinjamWarkahs = new HashSet<DetailPinjamWarkah>();
            this.DetailKembaliWarkahs = new HashSet<DetailKembaliWarkah>();
        }

        public string RecordStatus { get; set; }
        public string NW_Barcode { get; set; }
        public string Jenis { get; set; }
        public string NomorWarkah { get; set; }
        public string Tahun { get; set; }
        public string No_Album { get; set; }
        public string Status { get; set; }

        public virtual Album Album { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPinjamWarkah> DetailPinjamWarkahs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKembaliWarkah> DetailKembaliWarkahs { get; set; }
    }
}
