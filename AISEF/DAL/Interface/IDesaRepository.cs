using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IDesaRepository : IDALRepository<Desa>
    {
        /// <summary>
        /// Get Data By Id Desa
        /// </summary>
        /// <param name="idDesa"></param>
        /// <returns></returns>
        Desa GetDataById(string idDesa);
    }
}
