using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Kecamatan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kecamatan()
        {
            this.BukuTanahs = new HashSet<BukuTanah>();
            this.Desas = new HashSet<Desa>();
        }

        public string RecordStatus { get; set; }
        public string IDKecamatan { get; set; }
        public string NamaKecamatan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BukuTanah> BukuTanahs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Desa> Desas { get; set; }
    }
}
