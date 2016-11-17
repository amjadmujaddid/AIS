using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IComSettingService
    {
        /// <summary>
        /// Insert Data ComSetting
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataComSettingResponse InsertDataComSetting(InsertDataComSettingRequest request);

        /// <summary>
        /// Update Data ComSetting
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataComSettingResponse UpdateDataComSetting(UpdateDataComSettingRequest request);
    }

    #endregion

    #region Message

     public class InsertDataComSettingRequest
    {
        public ComSetting ComSetting { get; set; }
    }

    public class InsertDataComSettingResponse : ResponseBase
    {

    }

    public class UpdateDataComSettingRequest
    {
        public ComSetting ComSetting { get; set; }
    }

    public class UpdateDataComSettingResponse : ResponseBase
    {
        public ComSetting ComSetting { get; set; }
    }

    #endregion
}
