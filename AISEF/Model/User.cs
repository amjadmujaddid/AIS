using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.Model
{
    public class User
    {
        public string RecordStatus { get; set; }
        public string User_name { get; set; }
        public string NamaLengkap { get; set; }
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string LastPassword { get; set; }
        public string GroupAccessID { get; set; }
        public string ControlAccessID { get; set; }
    }
}
