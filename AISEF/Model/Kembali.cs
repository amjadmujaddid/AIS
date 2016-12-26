using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Kembali
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kembali()
        {
            this.DetailKembaliBTs = new HashSet<DetailKembaliBT>();
            this.DetailKembaliWarkahs = new HashSet<DetailKembaliWarkah>();
        }

        public string NomorKbl { get; set; }
        public System.DateTime TanggalKbl { get; set; }
        public int TotalKbl { get; set; }
        public string NIP { get; set; }
        public string User_name { get; set; }
        public string Note { get; set; }

        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKembaliBT> DetailKembaliBTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKembaliWarkah> DetailKembaliWarkahs { get; set; }
    }
}
