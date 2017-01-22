using AISEF.DAL;
using AISEF.DAL.Interface;
using AISEF.Model;
using AISService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService
{
    public class GenderService : IGenderService
    {
        #region Class Attribute

        IGenderRepository _genderRepo;

        #endregion

        #region Constructor

        public GenderService()
        {
            _genderRepo = new GenderRepository();
        }

        #endregion
        #region IGenderService Implementation

        public GetAllDataGenderResponse GetAllDataGender()
        {
            GetAllDataGenderResponse response = new GetAllDataGenderResponse();
            try
            {
                List<Gender> _listGender = _genderRepo.GetAll();
                response.GenderList.AddRange(_listGender);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        #endregion
    }
}
