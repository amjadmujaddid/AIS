using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IBukuTanahService
    { 
        /// <summary>
        /// Get All Data Buku Tanah
        /// </summary>
        /// <returns></returns>
        GetAllDataBukuTanahResponse GetAllDataBukuTanah();

        /// <summary>
        /// Get Data Buku Tanah By Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataBukuTanahByIdResponse GetDataBukuTanahById(GetDataBukuTanahByIdRequest request);

        /// <summary>
        /// Insert Data Buku Tanah
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataBukuTanahResponse InsertDataBukuTanah(InsertDataBukuTanahRequest request);

        /// <summary>
        /// Update Data Buku Tanah
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataBukuTanahResponse UpdateDataBukuTanah(UpdateDataBukuTanahRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataBukuTanahRequest
    {

    }

    public class GetAllDataBukuTanahResponse : ResponseBase
    {
        private List<BukuTanah> _bukuTanahList;

        public List<BukuTanah> BukuTanahList
        {
            get { return _bukuTanahList ?? (_bukuTanahList = new List<BukuTanah>()); }
        }
    }

    public class GetDataBukuTanahByIdRequest
    {
        public string NB_Barcode { get; set; }
    }

    public class GetDataBukuTanahByIdResponse : ResponseBase
    {
        public BukuTanah BukuTanah { get; set; }
    }

    public class InsertDataBukuTanahRequest
    {
        public BukuTanah BukuTanah { get; set; }
    }

    public class InsertDataBukuTanahResponse : ResponseBase
    {

    }

    public class UpdateDataBukuTanahRequest
    {
        public BukuTanah BukuTanah { get; set; }
    }

    public class UpdateDataBukuTanahResponse : ResponseBase
    {
        public BukuTanah BukuTanah { get; set; }
    }

    #endregion
}
