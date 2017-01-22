using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IWarkahService
    {
        /// <summary>
        /// Get All Data Warkah
        /// </summary>
        /// <returns></returns>
        GetAllDataWarkahResponse GetAllDataWarkah();

        /// <summary>
        /// Get Data Warkah By Id NW Warkah
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataWarkahByIdResponse GetDataWarkahById(GetDataWarkahByIdRequest request);

        /// <summary>
        /// Insert Data Warkah
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataWarkahResponse InsertDataWarkah(InsertDataWarkahRequest request);

        /// <summary>
        /// Update Data Warkah
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataWarkahResponse UpdateDataWarkah(UpdateDataWarkahRequest request);
    }

    #endregion

    #region  Message

    public class GetAllDataWarkahRequest
    {

    }

    public class GetAllDataWarkahResponse : ResponseBase
    {
        private List<Warkah> _warkahList;

        public List<Warkah> WarkahList
        {
            get { return _warkahList ?? (_warkahList = new List<Warkah>()); }
        }
    }

    public class GetDataWarkahByIdRequest
    {
        public string nwBarcode { get; set; }
    }

    public class GetDataWarkahByIdResponse : ResponseBase
    {
        public Warkah Warkah { get; set; }
    }

    public class InsertDataWarkahRequest
    {
        public Warkah Warkah { get; set; }
    }

    public class InsertDataWarkahResponse : ResponseBase
    {

    }

    public class UpdateDataWarkahRequest
    {
        public Warkah Warkah { get; set; }
    }

    public class UpdateDataWarkahResponse : ResponseBase
    {
        public Warkah Warkah { get; set; }
    }

    #endregion
}
