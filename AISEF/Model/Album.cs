using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            this.BukuTanahs = new HashSet<BukuTanah>();
            this.Warkahs = new HashSet<Warkah>();
        }

        public string RecordStatus { get; set; }
        public string No_Album { get; set; }
        public string Lemari { get; set; }
        public string Rak { get; set; }
        public string Blok { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BukuTanah> BukuTanahs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warkah> Warkahs { get; set; }
    }
}
