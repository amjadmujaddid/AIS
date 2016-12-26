using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class JenisHak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JenisHak()
        {
            this.BukuTanahs = new HashSet<BukuTanah>();
        }

        public string RecordStatus { get; set; }
        public string IDHak { get; set; }
        public string NamaHak { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BukuTanah> BukuTanahs { get; set; }
    }
}
