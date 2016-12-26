using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IDesaService
    {
        /// <summary>
        /// Get All Data Desa
        /// </summary>
        /// <returns></returns>
        GetAllDataDesaResponse GetAllDataDesa();

        /// <summary>
        /// Get Data Desa By Id Desa
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataDesaByIdResponse GetDataDesaById(GetDataDesaByIdRequest request);

        /// <summary>
        /// Insert Data Desa
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataDesaResponse InsertDataDesa(InsertDataDesaRequest request);

        /// <summary>
        /// Update Data Desa
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        UpdateDataDesaResponse UpdateDataDesa(UpdateDataDesaRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataDesaRequest
    {

    }

    public class GetAllDataDesaResponse : ResponseBase
    {
        private List<Desa> _desaList;

        public List<Desa> DesaList
        {
            get { return _desaList ?? (_desaList = new List<Desa>()); }
        }
    }

    public class GetDataDesaByIdRequest
    {
        public string idDesa { get; set; }
    }

    public class GetDataDesaByIdResponse : ResponseBase
    {
        public Desa Desa { get; set; }
    }

    public class InsertDataDesaRequest
    {
        public Desa Desa { get; set; }
    }

    public class InsertDataDesaResponse : ResponseBase
    {

    }

    public class UpdateDataDesaRequest
    {
        public Desa Desa { get; set; }
    }

    public class UpdateDataDesaResponse : ResponseBase
    {
        public Desa Desa { get; set; }
    }

    #endregion
}
