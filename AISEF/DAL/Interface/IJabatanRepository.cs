using AISEF.DAL.Interface;
using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IJabatanRepository : IDALRepository<Jabatan>
    {
        /// <summary>
        /// GetData By Id Jabatan
        /// </summary>
        /// <param name="idJabatan"></param>
        /// <returns></returns>
        Jabatan GetDataById(string idJabatan);
    }
}
