using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class Pinjam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pinjam()
        {
            this.DetailPinjamBTs = new HashSet<DetailPinjamBT>();
            this.DetailPinjamWarkahs = new HashSet<DetailPinjamWarkah>();
        }

        public string Nomorpjm { get; set; }
        public System.DateTime Tanggalpjm { get; set; }
        public int Totalpjm { get; set; }
        public string NIP { get; set; }
        public string User_name { get; set; }
        public string Note { get; set; }

        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPinjamBT> DetailPinjamBTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPinjamWarkah> DetailPinjamWarkahs { get; set; }
    }
}
