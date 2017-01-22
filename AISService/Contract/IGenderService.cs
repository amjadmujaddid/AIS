using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IGenderService
    {
        /// <summary>
        /// Get All Data Gender
        /// </summary>
        /// <returns></returns>
        GetAllDataGenderResponse GetAllDataGender();
    }

    #endregion

    #region Message

    public class GetAllDataGenderRequest
    {

    }

    public class GetAllDataGenderResponse : ResponseBase
    {
        private List<Gender> _genderList;

        public List<Gender> GenderList
        {
            get { return _genderList ?? (_genderList = new List<Gender>()); }
        }
    }

    #endregion
}
