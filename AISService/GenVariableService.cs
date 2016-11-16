using AISEF.DAL;
using AISEF.DAL.Interface;
using AISEF.Model;
using AISService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AISService
{
    public class GenVariableService : IGenVariableService
    {
        #region Class Attribute

        IGenVariableRepository _genVariableRepo;

        #endregion

        #region Constructor

        public GenVariableService()
        {
            _genVariableRepo = new GenVariableRepository();
        }

        #endregion

        #region IGenVariableService Implementation

        public GetDataComGenVariableStartWithResponse GetDataComGenVariableStartWith(GetDataComGenVariableStartWithRequest request)
        {
            GetDataComGenVariableStartWithResponse response = new GetDataComGenVariableStartWithResponse();
            try
            {
                List<GenVariable> _listGenVariable = _genVariableRepo.GetDataComGenVariableStartWith(request.variableStartWith);
                response.GenVariableList.AddRange(_listGenVariable);
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
