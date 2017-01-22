using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IStaffRepository : IDALRepository<Staff>
    {
        /// <summary>
        /// Get Data By NIP
        /// </summary>
        /// <param name="nip"></param>
        /// <returns></returns>
        Staff GetDataById(string nip);
    }
}
