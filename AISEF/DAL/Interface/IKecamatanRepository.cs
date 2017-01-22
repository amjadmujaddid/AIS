using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IKecamatanRepository : IDALRepository<Kecamatan>
    {
        /// <summary>
        /// Get Data By ID Kecamatan
        /// </summary>
        /// <param name="idKecamatan"></param>
        /// <returns></returns>
        Kecamatan GetDataById(string idKecamatan);
    }
}
