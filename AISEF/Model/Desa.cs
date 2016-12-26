using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Desa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Desa()
        {
            this.BukuTanahs = new HashSet<BukuTanah>();
        }

        public string RecordStatus { get; set; }
        public string IDDesa { get; set; }
        public string NamaDesa { get; set; }
        public string IDKecamatan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BukuTanah> BukuTanahs { get; set; }
        public virtual Kecamatan Kecamatan { get; set; }
    }
}
