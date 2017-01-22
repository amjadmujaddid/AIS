using AISEF.Model;
using AISService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IJabatanService
    {
        /// <summary>
        /// Get All Data Jabatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllDataJabatanResponse GetAllDataJabatan();

        /// <summary>
        /// Get Data Jabatan By Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataJabatanByIdResponse GetDataJabatanById(GetDataJabatanByIdRequest request);

        /// <summary>
        /// Insert Data Jabatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataJabatanResponse InsertDataJabatan(InsertDataJabatanRequest request);

        /// <summary>
        /// Update Data Jabatan
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataJabatanResponse UpdateDataJabatan(UpdateDataJabatanRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataJabatanRequest
    {

    }

    public class GetAllDataJabatanResponse : ResponseBase
    {
        private List<Jabatan> _jabatanList;

        public List<Jabatan> JabatanList
        {
            get { return _jabatanList ?? (_jabatanList = new List<Jabatan>()); }
        }
    }

    public class GetDataJabatanByIdRequest
    {
        public string IDJabatan { get; set; }
    }

    public class GetDataJabatanByIdResponse : ResponseBase
    {
        public Jabatan Jabatan { get; set; }
    }


    public class InsertDataJabatanRequest
    {
        public Jabatan Jabatan { get; set; }
    }

    public class InsertDataJabatanResponse : ResponseBase
    {

    }

    public class UpdateDataJabatanRequest
    {
        public Jabatan Jabatan { get; set; }
    }

    public class UpdateDataJabatanResponse : ResponseBase
    {
        public Jabatan Jabatan { get; set; }
    }

    #endregion
}
