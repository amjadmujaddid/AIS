using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IBukuTanahRepository : IDALRepository<BukuTanah>
    {
        /// <summary>
        /// Get Data By Id Buku Tanah
        /// </summary>
        /// <param name="nbBarcode"></param>
        /// <returns></returns>
        BukuTanah GetDataById(string nbBarcode);
    }
}
