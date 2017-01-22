using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IJenisHakService
    {
        /// <summary>
        /// Get All Data Jenis Hak
        /// </summary>
        /// <returns></returns>
        GetAllDataJenisHakResponse GetAllDataJenisHak();

        /// <summary>
        /// Get Data Jeni Hak By IdHak
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataJenisHakByIdResponse GetDataJenisHakById(GetDataJenisHakByIdRequest request);

        /// <summary>
        /// Insert Data Jenis Hak
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataJenisHakResponse InsertDataJenisHak(InsertDataJenisHakRequest request);

        /// <summary>
        /// Update Data Jenis Hak
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataJenisHakResponse UpdateDataJenisHak(UpdateDataJenisHakRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataJenisHakRequest
    {

    }

    public class GetAllDataJenisHakResponse : ResponseBase
    {
        private List<JenisHak> _jenisHakList;

        public List<JenisHak> JenisHakList
        {
            get { return _jenisHakList ?? (_jenisHakList = new List<JenisHak>()); }
        }
    }

    public class GetDataJenisHakByIdRequest
    {
        public string idHak { get; set; }
    }

    public class GetDataJenisHakByIdResponse : ResponseBase
    {
        public JenisHak JenisHak { get; set; }
    }

    public class InsertDataJenisHakRequest
    {
        public JenisHak JenisHak { get; set; }
    }

    public class InsertDataJenisHakResponse : ResponseBase
    {

    }

    public class UpdateDataJenisHakRequest
    {
        public JenisHak JenisHak { get; set; }
    }

    public class UpdateDataJenisHakResponse : ResponseBase
    {
        public JenisHak JenisHak { get; set; }
    }

    #endregion
}
