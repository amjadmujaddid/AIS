using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IAlbumRepository : IDALRepository<Album>
    {
        /// <summary>
        /// Get Data Album By Id
        /// </summary>
        /// <param name="noAlbum"></param>
        /// <returns></returns>
        Album GetDataById(string noAlbum);
    }
}
