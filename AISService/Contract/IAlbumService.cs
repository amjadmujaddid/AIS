using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IAlbumService
    {
        /// <summary>
        /// Get All Data Album
        /// </summary>
        /// <returns></returns>
        GetAllDataAlbumResponse GetAllDataAlbum();
        
        /// <summary>
        /// Get Data Album By Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataAlbumByIdResponse GetDataAlbumById(GetDataAlbumByIdRequest request);

        /// <summary>
        /// Insert Data Album
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataAlbumResponse InsertDataAlbum(InsertDataAlbumRequest request);

        /// <summary>
        /// Update Data Album
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataAlbumResponse UpdateDataAlbum(UpdateDataAlbumRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataAlbumRequest
    {

    }

    public class GetAllDataAlbumResponse : ResponseBase
    {
        private List<Album> _albumList;

        public List<Album> AlbumList
        {
            get { return _albumList ?? (_albumList = new List<Album>()); }
        }
    }

    public class GetDataAlbumByIdRequest
    {
        public string No_Album { get; set; }
    }

    public class GetDataAlbumByIdResponse : ResponseBase
    {
        public Album Album { get; set; }
    }

    public class InsertDataAlbumRequest
    {
        public Album Album { get; set; }
    }

    public class InsertDataAlbumResponse : ResponseBase
    {

    }

    public class UpdateDataAlbumRequest
    {
        public Album Album { get; set; }
    }

    public class UpdateDataAlbumResponse : ResponseBase
    {
        public Album Album { get; set;}
    }

    #endregion
}
