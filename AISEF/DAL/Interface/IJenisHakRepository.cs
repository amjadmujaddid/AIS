using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IJenisHakRepository : IDALRepository<JenisHak>
    {
        /// <summary>
        /// Get Data By Id Hak
        /// </summary>
        /// <param name="idHak"></param>
        /// <returns></returns>
        JenisHak GetDataById(string idHak);
    }
}
