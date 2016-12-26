using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Kembalis = new HashSet<Kembali>();
            this.Pinjams = new HashSet<Pinjam>();
        }

        public string RecordStatus { get; set; }
        public string NIP { get; set; }
        public string NamaLengkap { get; set; }
        public string IDJabatan { get; set; }
        public string IDJekel { get; set; }
        public string Alamat { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Jabatan Jabatan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kembali> Kembalis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pinjam> Pinjams { get; set; }
    }
}
