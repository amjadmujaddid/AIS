using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IKecamatanService
    {
        /// <summary>
        /// Get All Data Kecamatan
        /// </summary>
        /// <returns></returns>
        GetAllDataKecamatanResponse GetAllDataKecamatan();

        /// <summary>
        /// Get Data By Id Kecamatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataKecamatanByIdResponse GetDataKecamatanById(GetDataKecamatanByIdRequest request);

        /// <summary>
        /// Insert Data Kecamatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataKecamatanResponse InsertDataKecamatan(InsertDataKecamatanaRequest request);

        /// <summary>
        /// Update Data Kecamatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataKecamatanResponse UpdateDataKecamatan(UpdateDataKecamatanRequest request);

    }

    #endregion

    #region Message

    public class GetAllDataKecamatanRequest
    {

    }

    public class GetAllDataKecamatanResponse : ResponseBase
    {
        private List<Kecamatan> _kecamatanList;

        public List<Kecamatan> KecamatanList
        {
            get { return _kecamatanList ?? (_kecamatanList = new List<Kecamatan>()); }
        }
    }

    public class GetDataKecamatanByIdRequest
    {
        public string idKecamatan { get; set; }
    }

    public class GetDataKecamatanByIdResponse : ResponseBase
    {
        public Kecamatan Kecamatan { get; set; }
    }

    public class InsertDataKecamatanaRequest
    {
        public Kecamatan Kecamatan { get; set; }
    }

    public class InsertDataKecamatanResponse : ResponseBase
    {

    }

    public class UpdateDataKecamatanRequest
    {
        public Kecamatan Kecamatan { get; set; }
    }

    public class UpdateDataKecamatanResponse : ResponseBase
    {
        public Kecamatan Kecamatan { get; set; }
    }

    #endregion
}
