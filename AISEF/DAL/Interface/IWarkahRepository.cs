using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IWarkahRepository : IDALRepository<Warkah>
    {
        /// <summary>
        /// Get Data By Id NWBarcode
        /// </summary>
        /// <param name="nwBarcode"></param>
        /// <returns></returns>
        Warkah GetDataById(string nwBarcode);
    }
}
